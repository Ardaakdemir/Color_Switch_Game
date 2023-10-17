using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dondurme : MonoBehaviour
{
    public static float donusHizi = 0.6f;
    
    void Update()
    {
        transform.Rotate(0f,0f,donusHizi);
        
    }
}
