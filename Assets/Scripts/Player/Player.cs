using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float moveSpeed;

    CharacterController ch;
    public Material material;
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {

        ch = GetComponent<CharacterController>();

        rend = GetComponent<Renderer>();
        rend.sharedMaterial = material;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        ch.Move(new Vector3(horizontal, 0, vertical));
    }
}
