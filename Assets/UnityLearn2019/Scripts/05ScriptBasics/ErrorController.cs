using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace  ScriptBasics
{
    public class ErrorController : MonoBehaviour
    {
        void Start()
        {
            GameObject go = GameObject.Find("Demo");
            Debug.Log(go);
            Debug.Log(go.GetComponent<AudioSource>());
            Debug.Log(go.GetComponent<AudioSource>().clip);
            if (go.GetComponent<AudioSource>().clip != null)
            {

            }
            //go.SetActive(false);
        }
    }
}

