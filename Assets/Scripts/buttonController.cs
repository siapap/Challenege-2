using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonController : MonoBehaviour
{
    public void yesButton()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }

    public void noButton()
    {
        Application.Quit();
    }
}
