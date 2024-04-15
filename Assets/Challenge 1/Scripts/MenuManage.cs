using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class MenuManage : MonoBehaviour
{
    // Start is called before the first frame update
    public void Exit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }

   
}
