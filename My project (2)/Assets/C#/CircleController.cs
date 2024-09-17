using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleController : MonoBehaviour
{
    //create a variable to hold our Rigidbody2D
    private Rigidbody2D rb;

    public float ballSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnCollisionEnter(Collision collision)
    {
        //do something 
        Debug.Log("hit");
        //Destory(gameObject);
        rb.AddForce(rb.velocity*ballSpeed);
        //(2.3)*2 = (4,6)









    }
    



    



     
}


