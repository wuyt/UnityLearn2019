using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ScriptBasics
{
    public class Save : MonoBehaviour
    {

        void Start()
        {
            PlayerPrefs.SetFloat("DemoF", 3.14f);
            PlayerPrefs.SetString("DemoString", "saved string");
            PlayerPrefs.SetInt("DemoI", 250);
        }


    }

}
