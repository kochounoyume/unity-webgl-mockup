using System.Collections;
using UnityEngine;

namespace WebGLMockup
{
    public class Test : MonoBehaviour
    {
        private IEnumerator Start()
        {
            Debug.Log("Start" + Application.absoluteURL);
            var wait = new WaitForSeconds(5);

            yield return wait;
            WebUtils.MovePage("test");

            yield return wait;
            WebUtils.MovePage("test2");

            yield return wait;
            WebUtils.MovePage("");

            yield return wait;
        }
    }
}