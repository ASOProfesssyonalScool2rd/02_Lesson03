using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankScripts : MonoBehaviour
{
    private float ForWedSpeed = 2;
    [SerializeField] private float RotateSpeed = 0.1f; 
     public GameObject Upper = null;
     public GameObject Canon = null;

     public GameObject BallPrefab;

     public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0, 0, ForWedSpeed*Time.deltaTime);
        }
       if(Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0, RotateSpeed, 0);
        }
       if(Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0, -RotateSpeed, 0);  
        }

       if (Input.GetKey(KeyCode.S))
       {
           this.transform.Translate(0, 0, -ForWedSpeed*Time.deltaTime);  
       }
       if(Input.GetKey(KeyCode.LeftArrow))
        {
            Upper.transform.Rotate(0, -RotateSpeed, 0);
        }
       if(Input.GetKey(KeyCode.RightArrow))
        {
            Upper.transform.Rotate(0, RotateSpeed, 0);
        }

       if (Input.GetKeyDown(KeyCode.Space))
       {
           GameObject ball = (GameObject)Instantiate(BallPrefab, transform.position, Quaternion.identity);

           Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
           ballRigidbody.AddForce(transform.forward* Speed);
       }
       
    }
}
