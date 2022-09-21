using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carpisma : MonoBehaviour
{
    public GameObject insan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision nesne){
        Destroy(this.gameObject);//burada kodu attığımız nesneyi yok ediyoruz.
        Destroy(nesne.gameObject);//burada çarpıştığı diğer nesneyi yok ediyoruz.
        Instantiate(insan,this.gameObject.transform.position,this.gameObject.transform.rotation);//burada da kodu attığımız nesnenin position ve rotation değerlerinde dışarından aldığımız nesneyi oluşturuyoruz.

    }
}
