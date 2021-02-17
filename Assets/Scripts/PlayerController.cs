using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float Speed = 3.0F;
    public float RotateSpeed = 2.0F;
    public CharacterController controller;
    
    

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        /*
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float gravity = Physics.gravity.y * Time.deltaTime;

        Vector3 movementVector = new Vector3(moveX, gravity, moveZ);

        


        controller.Move(movementVector);
        */

        if (transform != null)
        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * RotateSpeed, 0);
            var forward = transform.TransformDirection(Vector3.forward);
            float curSpeed = Speed * Input.GetAxis("Vertical");
            controller.SimpleMove(forward * curSpeed);
        }



    }
}
