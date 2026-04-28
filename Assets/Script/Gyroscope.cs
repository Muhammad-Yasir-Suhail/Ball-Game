//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Gyroscope : MonoBehaviour
//{

//    public float movementSpeed = 10f;
//    Rigidbody body;
//    // Start is called before the first frame update
//    void Start()
//    {
//        body = GetComponent<Rigidbody>();
//        //Input.gyro.enabled = true;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        float tiltX = Input.acceleration.x;
//        float tiltY = Input.acceleration.y;
//        Vector3 movement = new Vector3(tiltX, 0f, tiltY);
//        body.AddForce(movement * movementSpeed);

//        //Quaternion deviceRotation = Input.gyro.attitude;
//        //Vector3 tilt = deviceRotation * Vector3.forward;
//        //body.AddForce(new Vector3(-tilt.y, 0, tilt.x) * movementSpeed);
//    }
//}







using UnityEngine;
using UnityEngine.UI;

public class Gyroscope : MonoBehaviour
{
    public float speed = 1000f; // control movement speed
    private Rigidbody rb;
    public float sp;
    
    // Get tilt values from phone
    float moveHorizontal = Input.acceleration.x * 10; // left-right tilt
    float moveVertical = Input.acceleration.y * 10;   // forward-back tilt (depends on orientation)

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sp = speed;
        
    }


    void FixedUpdate()
    {
        // Get tilt values from phone
        float moveHorizontal = Input.acceleration.x * 10; // left-right tilt
        float moveVertical = Input.acceleration.y * 10;   // forward-back tilt (depends on orientation)

        // Movement direction
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Apply force to move ball
        rb.AddForce(movement * sp);
    }

  
}
