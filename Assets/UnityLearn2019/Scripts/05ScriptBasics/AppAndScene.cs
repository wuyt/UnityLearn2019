using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ScriptBasics
{
    public class AppAndScene : MonoBehaviour
    {
        /// <summary>
        /// 退出应用
        /// </summary>
        public void AppExit()
        {
            if (Application.platform == RuntimePlatform.WindowsEditor)
            {
                UnityEditor.EditorApplication.isPlaying = false;
            }
            else
            {
                Application.Quit();
            }
        }
        /// <summary>
        /// 加载场景
        /// </summary>
        public void Load()
        {
            SceneManager.LoadScene("04SceneTarget");
            //SceneManager.LoadScene("04SceneTarget",LoadSceneMode.Additive);
            //SceneManager.LoadSceneAsync("04SceneTarget");
        }
        /// <summary>
        /// 返回第一个场景
        /// </summary>
        public void Back()
        {
            SceneManager.LoadScene(0);
        }
    }
}

