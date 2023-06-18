using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlsyerMovement : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField] float playerSpeed = 5f; //Sets the float value for playerSpeed, SerializeField add this to the PlayerMovement componant in Unity.
    [SerializeField] float jumpForce = 5f; //Sets the float value for jumpForce, SerializeField add this to the PlayerMovement componant in Unity.

    // Start is called before the first frame update
    void Start()
    {
        // Get the RigidBody from the player:
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Use the Unity preset Movement keys in 'Edit > Project Settings > Input Manager' and assigns the input (positve or negative value) to a variable.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //Sets the velocity of the player to the input value of Horizontal/Vertiacal * playerSpeed:
        rb.velocity = new Vector3(horizontalInput * playerSpeed, rb.velocity.y, verticalInput * playerSpeed);

        //Jump function for Spacebar, is Spacebar is pressed then...:
        if(Input.GetButtonDown("Jump"))
        {
            //Set the players Y axis (height) to increase by the jumpForce:
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }

    }
}
