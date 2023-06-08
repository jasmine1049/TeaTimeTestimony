using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager private_instance;
    public static GameManager Instance { get { return private_instance; } }

    public bool shouldDebug = true;

    private void Start() {
        private_instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SwitchScene(string sceneName) 
    {
        SceneManager.LoadScene(sceneName);
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
