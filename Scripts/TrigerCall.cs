using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrigerCall : MonoBehaviour
{
    private int Damage = 10;
    private UImanageR uiHealth;
    private MovePlayer movePlayer;
    private MovePlayer pSystem;
 


    void DamageCall()
    {
        CameraMove.Health -= Damage;
        uiHealth = GameObject.Find("UI_manager").GetComponent<UImanageR>();
        uiHealth.HealthTextOn();
        Death();
    }

   


    void Death()
    {
        if(CameraMove.Health <= 0)
        {
            movePlayer = GameObject.Find("StarSparrow11").GetComponent<MovePlayer>();

           
        
            Destroy(movePlayer,1f);


           
           
            Invoke("ReloadLevel",1f);

            
        }
    }

    void ReloadLevel()
    {
        int LevelIndex = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(LevelIndex);

        CameraMove.Health = 100;
    }

   

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        DamageCall();       
    }

   
}
