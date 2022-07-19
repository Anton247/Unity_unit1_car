using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    private float turnSpeed = 18.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Test Message"); 
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(forwardInput * Vector3.forward * Time.deltaTime * speed);
        if(forwardInput > 0)
            transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * turnSpeed);
        else if(forwardInput < 0)
            transform.Rotate(Vector3.up, -1 * horizontalInput * Time.deltaTime * turnSpeed);
    }
}
