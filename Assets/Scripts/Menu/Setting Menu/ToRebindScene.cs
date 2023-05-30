using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToRebindScene : MonoBehaviour
{
    public void LoadRebindSettingsScene() {
        SceneManager.LoadScene("Rebind Settings Scene");
    }
}
