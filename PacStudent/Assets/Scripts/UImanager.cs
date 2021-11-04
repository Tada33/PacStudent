using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnClickLevel1()
    {
        SceneManager.LoadScene("LevelScene");
    }

    public void OnClickLevel2()
    {
        SceneManager.LoadScene("StartScene");
    }
}
