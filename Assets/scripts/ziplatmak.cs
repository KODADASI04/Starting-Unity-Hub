using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ziplatmak : MonoBehaviour
{
    private Rigidbody rb;
    Vector3 kuvvet;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        kuvvet = new Vector3(0,10,0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            rb.AddForce(kuvvet);
        }
    }
}
