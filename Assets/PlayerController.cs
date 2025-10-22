using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D myRigid;
    float Jump_force = 680.0f;
    Vector3 Jump_Vector = Vector3.up;

    float Walk_force = 30.0f;
    float Walk_speed_max = 2.0f;
    int flip = 0;
    float Walk_speec_x;
    Vector3 myVector = Vector3.right; 

    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigid.AddForce(Jump_Vector*Jump_force);
        }
        flip = 0;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            flip = 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            flip = -1;
        }
        Walk_speec_x = Mathf.Abs(myRigid.velocity.x);
        if(Walk_speec_x < Walk_speed_max)
        {
            myRigid.AddForce(myVector * flip * Walk_force);
        }
        if(flip != 0)
        {
            transform.localScale = new Vector3(flip, 1, 1);
        }
    }
}
