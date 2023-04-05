using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float speed = 10;
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() 
    {
        float x = Input.GetAxis("Horizontal") * speed;
        float y = Input.GetAxis("Vertical") * speed;

        rb.AddForce(Vector3.forward * y, ForceMode.Impulse);
        rb.AddForce(Vector3.right * x, ForceMode.Impulse);
    }
}
