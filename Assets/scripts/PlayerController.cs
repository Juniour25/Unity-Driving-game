using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //variables
    public float speed=5.0f;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    public float turnSpeed=25.0f;
    public float horizontalInput;
    public float forwardInput;
    public string inputID;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //player inputs
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);
      transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
      transform.Rotate(Vector3.up, Time.deltaTime*turnSpeed*horizontalInput);
      if(Input.GetKeyDown(switchKey)){
        mainCamera.enabled= !mainCamera.enabled;
        hoodCamera.enabled= !hoodCamera.enabled;
      }

    }
}
