using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBarrier : MonoBehaviour
{

    public GameObject barrierPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Vector3 newPosition = hit.point;
                newPosition.y = 0.2f;
                Instantiate(barrierPrefab, newPosition, Quaternion.identity);
            }
        }
    }
}
