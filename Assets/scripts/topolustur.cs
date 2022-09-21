using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topolustur : MonoBehaviour
{
    public GameObject top;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pozisyon = new Vector3(Random.Range(-5,5),25,Random.Range(-5,5));
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(top,pozisyon,transform.rotation);
        }
    }
}
