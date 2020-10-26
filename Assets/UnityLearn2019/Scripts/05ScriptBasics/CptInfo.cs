using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace  ScriptBasics
{
    public class CptInfo : MonoBehaviour
    {

        void Start()
        {
            //gameObject.AddComponent<AudioSource>();

            //Destroy(GetComponent<AudioSource>());

            if (GetComponent<AudioSource>())
            {

            }

            //GetComponent<AudioSource>().enabled = false;

            //var rigd = GetComponent(typeof(Rigidbody)) as Rigidbody;
            //Debug.Log(rigd.name);
            //rigd.useGravity = true;
            //GetComponent<Rigidbody>().useGravity = true;
            //Debug.Log(GetComponent<Rigidbody>().name);

            //GetComponentInChildren<Rigidbody>().useGravity = true;
            //Debug.Log(GetComponentInChildren<Rigidbody>().name);

            //var rigid = FindObjectsOfType<Rigidbody>();
            //foreach (var item in rigid)
            //{
            //    item.useGravity = true;
            //    Debug.Log(item.name);
            //}

            //Debug.Log(GetComponentInParent<Rigidbody>().name);

            //Debug.Log(FindObjectOfType<Rigidbody>().name);

        }


    }
}

