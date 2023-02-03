using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager private_instance;
    public static GameManager Instance { get { return private_instance; } }

    public bool shouldDebug = true;

    private void Start() {
        private_instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
