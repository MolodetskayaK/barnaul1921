using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharControl : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController cControl;
    public float vSpeed = 4f; //5f
    public float hSpeed = 5f; //5f
    public float sensivity = 0.8f; //1.5f
    public float jumpVelocity = 3f; //3f
    public float piPower2 = 0.23f;
    //public Transform transform;
    float up = -0.1f;
    float downSpeed = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float up = -0.1f;
        if (Input.GetKey(KeyCode.Q))
        {
            up -= 2.1f;
        }
        if (Input.GetKey(KeyCode.E))
        {
            up += 2.1f;
        }
       /* if (Input.GetKeyDown(KeyCode.Q))
        {
            up -= 2f;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            up += 2.1f;
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            up += 2f;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            up -= 2.1f;
        }
        */
        if ((cControl.isGrounded) || (Input.GetKey(KeyCode.E)))
        {
            downSpeed = 0f;
            if (Input.GetKeyDown(KeyCode.Space)) downSpeed = -jumpVelocity;
        }
        else downSpeed += piPower2;
        Vector3 move = new Vector3(Input.GetAxis("Horizontal")*0.08f*hSpeed*Time.deltaTime, (up+0.1f-downSpeed)*0.02f*vSpeed * Time.deltaTime, Input.GetAxis("Vertical") * 0.08f*hSpeed * Time.deltaTime);
        move = transform.TransformVector(move);
        cControl.Move(move);
        Vector3 rotation = new Vector3(0, Input.GetAxis("Mouse X")*sensivity, 0);
        transform.Rotate(rotation);
    }
}
