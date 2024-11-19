using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : SingletonBehaviour<GameManager>
{
    public float Score { get; set; }

    public float temp;

    private void Awake()
    {
        SingletonInit();
        Score = 0.1f;
    }

    public void Pause()
    {
        temp = Score;
        Score = 0;
    }

    public void Resume()
    {
        Score = temp;
        temp = 0;
    }

    public void LoadScene(int buildIndex)
    {
        if(temp != 0)
        {
            Score = temp;
        }
        SceneManager.LoadScene(buildIndex);
    }
}
