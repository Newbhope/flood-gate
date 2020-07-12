using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float playerSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        processPlayerInput();
    }

    void processPlayerInput()
    {
        if (Input.GetKey("w"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(0, 0, playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey("a"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(-playerSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("s"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(0, 0, -playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey("d"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(playerSpeed * Time.deltaTime, 0, 0);
        }
    }
}
