using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ScriptBasics
{
    public class TFInfo : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            transform.localPosition = new Vector3(1.5f, 1, 0);
            Debug.Log(transform.position.x);
            transform.localEulerAngles = new Vector3(0, 0, 15);
            transform.localScale = new Vector3(1, 2, 0.1f);
        }
    }
}

