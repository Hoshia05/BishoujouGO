using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool isFirst = false;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        // Don't destroy this when move scenes.
        DontDestroyOnLoad(Instance);
    }

    public void SwitchToOutside()
    {
        SceneManager.LoadScene("OutsideScreen");
    }

    public void SwitchToHome()
    {
        SceneManager.LoadScene("HomeScreen");
    }
}
