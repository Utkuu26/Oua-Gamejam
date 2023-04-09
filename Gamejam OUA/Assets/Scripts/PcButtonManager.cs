using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PcButtonManager : MonoBehaviour
{
    
    public void LoadSceneRyhtm()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single); 
    }

    public void LoadSceneHyperCasual()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single); 
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single); 
    }

}
