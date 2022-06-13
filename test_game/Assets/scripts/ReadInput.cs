using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ReadInput : MonoBehaviour
{
    public static string input;
    public static int intInput;
    
    public void ReadStringInput(string s)
    {
        input = s;
        
        int.TryParse(input, out intInput);

        Debug.Log(intInput);

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("big enter key was pressed.");
            SceneManager.LoadScene(sceneName: "TestGame");
        }
    }
}
