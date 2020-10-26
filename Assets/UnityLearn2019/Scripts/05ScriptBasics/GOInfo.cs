using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.XR;

namespace  ScriptBasics
{
    public class GOInfo : MonoBehaviour
    {
        public GameObject go;
        public GameObject[] gos;

                void Start()
        {
            //Debug.Log(gameObject.name);
            //Debug.Log(go);
            //Debug.Log(gos[1]);
            //Debug.Log(GameObject.Find("/GameObject (4)"));
            //GameObject.Find("GameObject (4)");

            //GameObject.FindGameObjectWithTag("mytag").SetActive(false);
            //GameObject[] gots = GameObject.FindGameObjectsWithTag("mytag");
            //Debug.Log(gots[1].name);
            //Debug.Log(FindObjectOfType<BoxCollider>().gameObject);

            //transform.Find("GameObject (4)").gameObject.SetActive(false);

            //Debug.Log(transform.Find("GameObject (3)/GameObject (5)").gameObject.name);

            //Debug.Log(gameObject.name);
            //gameObject.name = "1096";
            //Debug.Log(go.activeSelf);
            //go.SetActive(true);

            go.transform.SetParent(transform);

            //new GameObject("486",typeof(Rigidbody));

            //Destroy(go);

            //if (go)
            //{
            //    go.name = "1096";
            //}

            //for(int i = 0; i < transform.childCount; i++)
            //{
            //    Debug.Log(transform.GetChild(i).name);
            //}

            //foreach(Transform item in transform)
            //{
            //    Debug.Log(item.name);
            //}
        }
    }
}

