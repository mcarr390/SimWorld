using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneRepo : MonoBehaviour
{
    public Scene startMenuScene;
    public Scene firstLevelScene;

    // Use this for initialization
    void Start()
    {
        int sceneCount = SceneManager.sceneCountInBuildSettings;
        string[] scenes = new string[sceneCount];

        for (int i = 0; i < sceneCount; i++)
        {
            scenes[i] = Path.GetFileNameWithoutExtension(SceneUtility.GetScenePathByBuildIndex(i));
            Debug.Log("Name: " + scenes[i]);
        }
        Debug.Log("scene count: " + scenes.Length);
    }

    
}
