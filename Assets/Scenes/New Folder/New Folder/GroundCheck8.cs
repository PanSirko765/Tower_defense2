using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{

    public bool isGround = true;
    
    
    
    private void OnTriggerEnter(Collider other)
    {
        isGround = true;
        
    }

    private void OnTriggerExit(Collider other)
    {
        isGround = false;
    }

}
