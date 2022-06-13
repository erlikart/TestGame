using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTheGame : MonoBehaviour
{
    public void MoveToScene()
    {
        SceneManager.LoadScene(sceneName: "MainMenu");
    } 
}