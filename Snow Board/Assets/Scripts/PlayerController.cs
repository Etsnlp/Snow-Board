using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
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

}
