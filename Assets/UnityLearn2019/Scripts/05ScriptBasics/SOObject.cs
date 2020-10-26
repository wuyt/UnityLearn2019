using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace ScriptBasics
{
    [CreateAssetMenu]
    public class SOObject : ScriptableObject
    {
        public string soName;
        public int soNumber;
        public Color soColer;
        public Vector3 soPoint;
        public float[] soFs;
        public SODemo soDemo;

#if UNITY_EDITOR
        [MenuItem("Demo/Create SO")]
        public static void CreateItemSet()
        {
            var objSet = CreateInstance<SOObject>();
            string savePath = EditorUtility.SaveFilePanel(
                "save",
                "Assets/",
                "SOObject",
                "asset"
            );
            if (savePath != "")
            {
                savePath = "Assets/" + savePath.Replace(Application.dataPath, "");
                UnityEditor.AssetDatabase.CreateAsset(objSet, savePath);
                UnityEditor.AssetDatabase.SaveAssets();
            }
        }
#endif

    }

}
