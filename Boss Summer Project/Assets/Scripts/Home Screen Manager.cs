using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEditor;

public class HomeScreenManager : MonoBehaviour
{
    /*
    void Start()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
    */
    public void ChangeScene(int sceneBuildIndex)
    {
        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
    }
    public void ExitApplication()
    {
        EditorApplication.ExitPlaymode();
    }
}
