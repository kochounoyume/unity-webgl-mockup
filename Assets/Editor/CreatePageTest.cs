using System.Collections;
using System.IO;
using Cysharp.Threading.Tasks;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Editor
{
    public class CreatePageTest
    {
        private const string WebGLBuildPath = "builds/WebGL/WebGL";

        [UnityTest]
        public IEnumerator CreatePage() => UniTask.ToCoroutine(async () =>
        {
            var parent = Directory.GetParent(Application.dataPath)?.FullName ?? "";
            var originalPagePath = Path.Combine(parent, WebGLBuildPath, "index.html");
            if (!File.Exists(originalPagePath))
            {
                Assert.Fail("Not yet done WebGL build.");
            }

            var pages = new[] {"hoge.html", "fuga.html", "piyo.html"};
            var tasks = new UniTask[pages.Length];
            for (int i = 0; i < tasks.Length; i++)
            {
                var pagePath = Path.Combine(parent, WebGLBuildPath, pages[i]);
                tasks[i] = UniTask.Defer((originalPagePath, pagePath), static async args =>
                {
                    var (origin, copy) = args;
                    await using var originalPageStream
                        = new FileStream(origin, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, true);
                    await using var newPageStream
                        = new FileStream(copy, FileMode.Create, FileAccess.Write, FileShare.None, 4096, true);
                    await originalPageStream.CopyToAsync(newPageStream);
                });
            }
            await UniTask.WhenAll(tasks);

            Assert.Pass();
        });
    }
}