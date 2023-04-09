using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PcButtonManager : MonoBehaviour
{
    
    public void LoadSceneRyhtm()
    {
        SceneManager.LoadScene(0); 
    }

    public void LoadSceneHyperCasual()
    {
        SceneManager.LoadScene(2); 
    }

    public void LoadScenePixelArt()
    {
        SceneManager.LoadScene(3); 
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene(1); 
    }

}
