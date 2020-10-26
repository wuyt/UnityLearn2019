using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace ScriptBasics
{
    public class MoveGo : MonoBehaviour
    {
        public Transform[] tfs;
        public float speed;
        public Transform relative;
        public Transform target;

        // Update is called once per frame
        void Update()
        {
            //Debug.Log(Time.deltaTime);

            tfs[0].Translate(Vector3.right * speed * Time.deltaTime);
            tfs[1].Translate(speed * Time.deltaTime, 0, 0, Space.Self);
            tfs[2].Translate(Vector3.right * speed * Time.deltaTime, Space.World);
            tfs[3].Translate(Vector3.right * speed * Time.deltaTime, relative);

            tfs[4].localPosition += transform.right * speed * Time.deltaTime;
            tfs[5].position += transform.right * speed * Time.deltaTime;

            tfs[6].position = Vector3.MoveTowards(tfs[6].position, target.position, speed * Time.deltaTime);
        }
    }
}

