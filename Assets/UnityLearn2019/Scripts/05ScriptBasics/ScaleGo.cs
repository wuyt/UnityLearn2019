using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ScriptBasics
{
    public class ScaleGo : MonoBehaviour
    {
        public float speed;
        void Update()
        {
            transform.localScale += Vector3.one * speed * Time.deltaTime;
        }
    }
}

