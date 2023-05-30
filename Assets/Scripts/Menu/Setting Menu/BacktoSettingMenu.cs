using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoSettingMenu : MonoBehaviour
{
    public void LoadSettingMenu() {
        SceneManager.LoadScene("Setting Menu");
    }
}
