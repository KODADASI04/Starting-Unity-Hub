using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tekerlekdondurme : MonoBehaviour
{   Vector3 dondurme;
    public int xi,yi,zi;

    // Start is called before the first frame update
    void Start()
    {
        dondurme = new Vector3(xi,yi,zi);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(dondurme*Time.deltaTime);//Time.deltaTime kullanılan cihazın gecikme süresine göre dönüşü ayarlar.
    }
}
