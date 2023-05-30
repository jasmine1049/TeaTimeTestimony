using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CalloutMap : MonoBehaviour
{
    [SerializeField]
    private GameObject map;

    public void UseMap() {
        if(!map.activeSelf) {
            map.SetActive(true);
        }
    }

    public void CloseMap() {
        if(map.activeSelf) {
            map.SetActive(false);
        }
    }

    public void RedirectTo(int MapIndex) {
        SceneManager.LoadScene(MapIndex);
    }
}
