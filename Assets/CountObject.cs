using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountObject : MonoBehaviour
{
    Scene scene = SceneManager.GetActiveScene();
    private int count;
    void keepSceneNum()
    {
        if (scene.name == "Level2")
        {
            count = 4;
        }
    }
    

}
