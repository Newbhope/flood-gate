using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierHealth : MonoBehaviour
{
    public float health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        health--;
        Vector3 currentPosition = gameObject.transform.position;
        Vector3 newPosition = new Vector3(currentPosition.x, currentPosition.y - 0.002f, currentPosition.z);

        gameObject.transform.position = newPosition;
        if (health <= 0)
        {
            gameObject.SetActive(false);
        }
        /*
        
        // Why doesnt the water move when this is gone lol
        if (health <= 0)
        {
            gameObject.SetActive(false);
        }
        */
    }
}
