using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ScriptBasics
{
    public class RotateGO : MonoBehaviour
    {
        public float speed;
        public Transform[] tfs;


        // Update is called once per frame
        void Update()
        {
            //tfs[0].Rotate(speed * Time.deltaTime, 0, 0);
            tfs[0].Rotate(Vector3.right * speed * Time.deltaTime, Space.Self);
            tfs[1].Rotate(Vector3.right * speed * Time.deltaTime, Space.World);
            tfs[2].RotateAround(tfs[1].position, Vector3.up, speed * Time.deltaTime);
            tfs[3].LookAt(tfs[2]);
            //tfs[4].localScale += Vector3.one * speed * Time.deltaTime;
        }
    }
}

