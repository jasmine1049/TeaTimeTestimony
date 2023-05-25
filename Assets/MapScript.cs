using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapScript : MonoBehaviour
{
    public Image map;
    
    private bool mapOn;

    // Start is called before the first frame update
    void Start()
    {
        map.enabled = false;
        mapOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (mapOn)
            {
                map.enabled = false;
                mapOn = false;
            }
            else
            {
                map.enabled = true;
                mapOn = true;
            }
        }
    }
}
