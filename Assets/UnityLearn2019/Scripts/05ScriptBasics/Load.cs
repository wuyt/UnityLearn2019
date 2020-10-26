using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ScriptBasics
{
    public class Load : MonoBehaviour
    {
        void Start()
        {
            Debug.Log(PlayerPrefs.GetFloat("DemoF"));
            Debug.Log(PlayerPrefs.GetString("DemoString"));
            Debug.Log(PlayerPrefs.GetInt("DemoI"));
            Debug.Log(PlayerPrefs.GetString("none", "this is default"));
        }


    }

}
