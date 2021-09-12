using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    [SerializeField] Transform prefubBOX;
    [SerializeField] float speedAttack = 1;
    public GameObject bull;
    public Transform player;
    
    void Start()
    {
        InvokeRepeating("Fire", 2, speedAttack );
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player, player.transform.position);
    }

   

    public void Fire()
    {
      GameObject boxPrefub = Instantiate(bull, transform.position, transform.rotation);
      boxPrefub.transform.parent = prefubBOX;
    }

}
