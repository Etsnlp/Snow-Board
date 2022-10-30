using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float boostSpeed = 20f;
    [SerializeField] float normalSpeed = 12f;
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector;
    bool canMove = true;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
        RotationControl();
        RespondToBoost();
        }
    }

    public void StopControl()
    {
        canMove = false;
        surfaceEffector.enabled = !surfaceEffector.enabled;
    }

    void RotationControl()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
       {
        rb2d.AddTorque(torqueAmount);
       } 
       
       else if(Input.GetKey(KeyCode.RightArrow))
       {
        rb2d.AddTorque(-torqueAmount);
       }
    }

    void RespondToBoost()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector.speed = boostSpeed;
        }
        else
        {
            surfaceEffector.speed = normalSpeed;
        }
    }

}
