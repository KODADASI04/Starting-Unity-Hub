using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zemingecmesay : MonoBehaviour
{
    // Start is called before the first frame update
    int topsayi;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider gecme){//kodu koyduğumuz obje ile başka bir cisim çarpıştığında bu fonksiyon çalışır.
        topsayi++;
        Debug.Log(topsayi);
        Debug.Log("Top Zeminden Geçti "+gecme.name);//name fonksiyonu cismin çarptığı diğer cismin ismini verir.
    }
}
