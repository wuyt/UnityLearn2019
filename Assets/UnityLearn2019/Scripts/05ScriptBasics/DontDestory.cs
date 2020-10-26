using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptBasics
{
    public class DontDestory : MonoBehaviour
    {
        void Start()
        {
            DontDestroyOnLoad(gameObject);
            //Destroy(gameObject);
        }
    }
}