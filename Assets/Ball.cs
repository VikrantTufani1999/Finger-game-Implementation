using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    private Rigidbody ball;
    public float BallSpeed;
    public float turnSpeen = 1;
    public float smoothTime;

    //public GameObject Lose;
    public GameObject gameOver;
    Vector3 vel;

    private Vector3 mousepoint;
    private Vector3 screenPoint;
    private Vector3 offset;
    private float mZCoord;

    public bool dragging = false;

    void Start()
    {
        ball=GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        offset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        mousepoint = Input.mousePosition;

        mousepoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousepoint);
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + offset;
        //dragging = true;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //dragging = true;
            //ball.AddForce(new Vector3(0, 0.1f * Time.deltaTime, 0));
            ball.velocity = new Vector3(0, 0.1f, 0);
        }

        else if (Input.GetMouseButtonUp(0))
        {
            //dragging = false;
            SceneManager.LoadScene("SampleScene");
        }

        //if (dragging)
        //{
        //    transform.position = new Vector3(mousepoint.x, mousepoint.y, transform.position.z);
        //}

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