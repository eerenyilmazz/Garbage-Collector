using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class JoystickControl : MonoBehaviour {
    


    float speed = 10;
    public Joystick joystick;
    Rigidbody rb;
    Ray ray;
    RaycastHit hit;
    GameObject Body;
    private void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joystick.gameObject.GetComponent<Image>().enabled = true;
        rb = GetComponent<Rigidbody>();
    }
    public void FixedUpdate()
    {
        //  Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        //  rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        var _horizontal = joystick.Horizontal;
        var _vertical = joystick.Vertical;

        // Direction pointing to
        Vector3 newPos = new Vector3(_horizontal, 0, _vertical);

        // Get the current position of object
        var currentPos = rb.position;
        RaycastHit hit;
        Physics.Raycast(transform.position, -Vector3.up, out hit);
        
        if (Input.GetMouseButton(0))
        {
            var facePos = currentPos + newPos;
        
            transform.LookAt(new Vector3(facePos.x, rb.position.y, facePos.z));

            
            rb.velocity = transform.forward*2;
            
        }
        //transform.LookAt(rb.velocity);
        transform.rotation = Quaternion.Euler(0, transform.eulerAngles.y, 0);
        

    }
}
