using System.Collections;
using UnityEngine;
using WebGLMockup;

namespace DefaultNamespace
{
    public class Test : MonoBehaviour
    {
        private IEnumerator Start()
        {
            var wait = new WaitForSeconds(5);

            yield return wait;
            WebUtils.MovePageURL("test");

            yield return wait;
            WebUtils.MovePageURL("test2");

            yield return wait;
            WebUtils.MovePageURL("");

            yield return wait;
            WebUtils.ConsoleLog(Application.absoluteURL);
            WebUtils.ConsoleWarn(Application.absoluteURL);
            WebUtils.ConsoleError(Application.absoluteURL);
        }
    }
}