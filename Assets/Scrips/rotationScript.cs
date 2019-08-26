using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationScript : MonoBehaviour
{


    

    void Start()
    {
        
    }

   
    void Update()
    {
        
        transform.Rotate(Vector3.up, 100 * Time.deltaTime); 

        
    
    }
}
