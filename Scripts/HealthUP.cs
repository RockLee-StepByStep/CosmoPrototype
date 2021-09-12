using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUP : MonoBehaviour
{

   
    
    private void Start()
    {
    //var hp = GameObject.FindWithTag("HPup");    
    }

    private void Update()
    {
        
    }


    
    public void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        Debug.Log("asdasd");
        CameraMove.Health += 40;
        if (CameraMove.Health > 100)
        {
            CameraMove.Health = 100;
        }
            
            
        

        
    }
}
