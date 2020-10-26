using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ScriptBasics
{
    public class Instance : MonoBehaviour
    {
        public GameObject obj;
        public Transform parent;
        public void IstGO()
        {
            var go = Instantiate(obj, new Vector3(1f, 1f, 1f), Quaternion.identity);
            go.transform.position = new Vector3(2f, 2f, 2f);
        }

    }

}
