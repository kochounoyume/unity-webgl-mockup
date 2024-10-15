using System.Collections;
using TMPro;
using UnityEngine;

namespace WebGLMockup
{
    public class Test : MonoBehaviour
    {
        [SerializeField] private TextAsset textAsset;
        [SerializeField] private TextMeshProUGUI text;

        private IEnumerator Start()
        {
            var span = textAsset.GetData<byte>().AsSpan();
            var array = new char[300];
            var l = System.Text.Encoding.UTF8.GetChars(span, array);
            text.SetCharArray(array, 0, l);

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