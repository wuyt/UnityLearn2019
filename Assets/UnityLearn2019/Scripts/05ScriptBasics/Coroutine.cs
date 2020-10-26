using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ScriptBasics
{
    public class Coroutine : MonoBehaviour
    {

        void Start()
        {

            Debug.Log("start ->" + Time.time);
            //StartCoroutine("LearnCoroutine");
            //Invoke("LearnInvoke", 2);
            // InvokeRepeating("LearnInvoke", 0, 2);
            Debug.Log("end ->" + Time.time);

        }

        IEnumerator LearnCoroutine()
        {
            Debug.Log("start coroutine-->" + Time.time);
            yield return new WaitForSeconds(1);
            Debug.Log("end coroutine-->" + Time.time);
        }

        void LearnInvoke()
        {
            Debug.Log("Learn Invoke-->" + Time.time);
        }
    }
}

