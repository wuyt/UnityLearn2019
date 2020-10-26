using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ScriptBasics
{
    public class CallCpnt : MonoBehaviour
    {
        public GameObject go;

        void Start()
        {
            if (go)
            {
                //go.GetComponent<CallCpnt>().BeCalled();
                go.SendMessage("BeCalled");
                //go.BroadcastMessage("BeCalled");
                //go.SendMessageUpwards("BeCalled");
            }
        }

        public void BeCalled()
        {
            Debug.Log(gameObject.name);
        }

    }
}

