using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ScriptBasics
{
    [RequireComponent(typeof(AudioSource))]
    public class Others : MonoBehaviour
    {
        public int top = 0;
        [Space(50)]
        public int num = 0;
        [TextArea(3, 10)]
        public string info;
        [Header("血量设置")]
        public int health = 0;
        [Tooltip("设置的提示")]
        public int money = 0;

        void Start()
        {
            //Debug.Log(Application.dataPath);
            //Debug.Log(Application.temporaryCachePath);
            //Debug.Log(Application.streamingAssetsPath);
            //Debug.Log(Application.persistentDataPath);

            //print("print");
            //Debug.Log("log");
            //Debug.LogWarning("LogWarning");
            //Debug.LogError("LogError");

            //        Debug.Log(Application.platform);
            //#if UNITY_EDITOR
            //        if (Application.platform == RuntimePlatform.WindowsEditor)
            //        {
            //            Debug.Log("platform");
            //        }
            //#endif
            Debug.Log(Random.insideUnitSphere);
            Debug.Log(Random.insideUnitCircle);
            Debug.Log(Random.onUnitSphere);
            Debug.Log(Random.rotation);
            Debug.Log(Random.ColorHSV());


        }


    }
}

