using System.Collections;
using System.Collections.Generic;
using UnityEngine;
  
public class BodyRotator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject go;
    public Joystick JS;
    public float Speed=30;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (JS.Horizontal != 0)
        {
            go.transform.Rotate(Vector3.up, JS.Horizontal * -Speed * Time.deltaTime, Space.World);
           go.transform.Rotate(Vector3.right, JS.Vertical * Speed * Time.deltaTime, Space.World);
        }
    }
}
