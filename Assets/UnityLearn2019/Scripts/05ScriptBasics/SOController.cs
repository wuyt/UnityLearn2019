using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ScriptBasics
{
    public class SOController : MonoBehaviour
    {
        public int blood;
        public string npcName;
        public SOObject soObject;

        public SODemo soDemo;




        void Start()
        {
            Debug.Log(soObject.soColer);
        }

    }

}
