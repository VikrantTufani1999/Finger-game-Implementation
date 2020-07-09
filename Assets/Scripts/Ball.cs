using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    // [Ball-Related Declarations]
    private Rigidbody ball;
    public float BallSpeed;
    public float turnSpeen = 1;
    public float smoothTime;
    Vector3 vel;
    public bool dragging = false;

    // [Panel-Related Declaration]
    public GameObject gameOver;
    
    // [Mouse-Position Related Declarations]
    private Vector3 mousepoint;
    private Vector3 screenPoint;
    private Vector3 offset;
    private float mZCoord;

    void Start()
    {
        ball=GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        offset = gameObject.transform.position - GetMouseWorldPos();

        if (Input.GetMouseButton(0))
        {
            ball.velocity = new Vector3(0, 0.001f, 0);
        }
    }

    private Vector3 GetMouseWorldPos()          // Get Mouse Position
    {
        mousepoint = Input.mousePosition;

        mousepoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousepoint);
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + offset;
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            SceneManager.LoadScene(0);
        }

        // [To Apply The Sliding of LEFT OR RIGHT LOGIC]

        /*if (Input.GetAxis("Mouse X") > 0 )
        {
            //Code for action on mouse moving left
            ball.AddForce(new Vector3(10, 0, 0));
            print("Mouse moved left");
        }
        if (Input.GetAxis("Mouse X") < 0)
        {
            //Code for action on mouse moving right
            ball.AddForce(new Vector3(-10, 0, 0));
            print("Mouse moved right");
        }*/
    }

    void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.tag == "Finish")
        {
           gameOver.SetActive(true);
        }
    }
}