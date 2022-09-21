using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axisalma : MonoBehaviour
{
    Rigidbody rb;
    public float hiz = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        Vector3 kuvvet = new Vector3(yatay,0,dikey);
        rb.AddForce(kuvvet*hiz);
    }
}
