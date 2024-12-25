using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Action eventUpdateCoin;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoadMenuMiniGame()
    {
        SceneManager.LoadSceneAsync("MenuMiniGames");
    }

    public void LoadAlmanec()
    {
        SceneManager.LoadSceneAsync("Almanac");
    }

    public void LoadDining()
    {
        SceneManager.LoadSceneAsync("Dinning");
        
    }
}
