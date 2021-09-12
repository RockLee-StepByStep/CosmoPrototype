using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{

    public GameObject enemyes;

    public static int enemyCount;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("EnemyPreff", 2, Random.Range(1, 4));
    }

    // Update is called once per frame
    void Update()
    {
       
       
            
            
    }


    void EnemyPreff()
    {
        Instantiate(enemyes,transform.position,transform.rotation);
    }
}
