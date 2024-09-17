using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    public GameObject circle;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { //get screen position of the mouse and insert it into a Vector2 variable
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
      
        //convert the screen position of the mouse to a game world position
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(circle, objPosition, Quaternion.identity);
        }
    }
}
