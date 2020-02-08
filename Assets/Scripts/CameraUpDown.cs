using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraUpDown : MonoBehaviour
{
    public float sensivity = 1f;
    public Transform selfTransform;
    public float x1 = 0f, x2 = 0f, x3 = 0f, x4=0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = new Vector3(-Input.GetAxis("Mouse Y") * sensivity, 0, 0);
        //Transform transform2 = transform;
        float rot = transform.eulerAngles[0];
        //transform2.Rotate(rotation);
        //float rot2 = transform2.eulerAngles[1];
        /*if ((System.Math.Abs(rot2)<=90) != (System.Math.Abs(rot) <= 90))
        {
            if (System.Math.Abs(rot2) <= 90)
        
        }*/
        //Transform testTransform = new Transform;
        //testTransform.rotation=
        float shouldBlock = rot + rotation[0];

        if (true)//(Input.GetKey(KeyCode.F))
        {
            x1 = transform.eulerAngles[0];
            x2 = transform.eulerAngles[1];
            x3 = transform.eulerAngles[2];
            x4 = shouldBlock;
        }
        
        if ((shouldBlock >= 85f) && (shouldBlock <= 275f))
        {   
            if (rot <= 100) transform.Rotate(new Vector3(85-rot, 0, 0));
            else transform.Rotate(new Vector3(-rot-85, 0, 0));
        }
        else transform.Rotate(rotation);

        //if (System.Math.Abs(transform2.eulerAngles[0])>=90)
       // {
        //    transform.Rotate(new Vector3(System.Math.Sign(rot) * (90 - System.Math.Abs(rot)), 0, 0));
        //}
        //else transform.Rotate(rotation);
    }
}
