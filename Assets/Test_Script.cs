using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Script : MonoBehaviour
{
    Vector3 myVector = new Vector3(0, 0, 0);
    
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myVector = Vector3.right;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            myVector = Vector3.left;
        }
        else
        {
            myVector = Vector3.zero;
        }
        transform.Translate(myVector * 3.0f * Time.deltaTime);
    }
}
