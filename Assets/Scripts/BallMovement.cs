using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerScript : MonoBehaviour
{
    /*
    // Set up a basic scene - just a camera with an orthographic view and a z distance of -10. Drag a background on to the scene if you like. Add 2 GameObjects with sprites to the scene. I have a bubble and a puffer fish so I named them "bubble" and "puffer". Add a RigidBody2D to both and set them to Kinematic. Add a 2D collider to both (I went with a circle colider) and make sure at least one of them has the trigger box checked.

    public Camera myCam;
    public GameObject puffer;
    public GameObject bubble;

    // Attach this script to the bubble and drag the above components over to their respective script slots in the inspector. Using a true/false here means that your mouse won't drop the bubble if it is moving too fast...

    public bool dragging = false;
    private float distanceFromCamera = 10f;
    private Vector3 mousePosition;


    void Start()
    {
        //This grabs the Pufferfish and makes it move downwards with a fixed velocity of -5;
        puffer.GetComponent<Rigidbody>().velocity = new Vector2(0, 5f);
    }

    void Update()
    {

        // You need to update the mouse position constantly and get its co-ordinates in world space instead of janky mouse space.

        mousePosition = myCam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanceFromCamera));

        // You can Raycast to see if you are clicking on the bubble. The Input.GetMouseButtonDown (0) is checking if the left mouse button has been clicked.

        if (Input.GetMouseButtonDown(0))
        {
            if (hit & amp; &amp; hit.collider.name == "") {
                dragging = true;
            }
        }

        // This makes the bubble follow the mouse.

        if (dragging)
        {
            transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
        }

        // This stops the bubble from following the mouse if the button is released.

        if (Input.GetMouseButtonUp(0))
        {
            dragging = false;
        }

        // If the pufferfish goes off the bottom of the screen we just move it back to the top for now. We can pretend like it is a new fish...

        if (puffer.transform.position.y & lt;= -8) {
            MovePufferFishToTop();
        }
    }

    // If you collide with the fish it also just makes a new one. Here is where you would loose if you were trying to avoid the fish..

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == puffer)
        {
            MovePufferFishToTop();
        }
    }

    // this quick code moves the pufferfish back to the top and randomises the x position so it appears in different places.

    void MovePufferFishToTop()
    {
        float randomx = Random.Range(-6, 6);
        puffer.transform.position = new Vector3(randomx, 8, puffer.transform.position.z);
    }
    */
}