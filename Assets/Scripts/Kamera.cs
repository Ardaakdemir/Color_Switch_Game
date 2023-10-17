using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    public Transform TopPozisyon;
   
    void Update()
    {
        if(TopPozisyon.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x,TopPozisyon.position.y,transform.position.z);
            
        }
    }
}
