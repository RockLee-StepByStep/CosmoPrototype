using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] GameObject enemyExplosion;
    [SerializeField] Transform boxPrefub;
    [SerializeField] int EnemyHP = 3;
    [SerializeField] GameObject point;


    public GameObject explosion;
    scorePoint sc;


    private int balls = 20;

    private void Start()
    {
        sc = GameObject.FindObjectOfType<scorePoint>();
    }

    public void OnParticleCollision(GameObject other)
    {
        DeathPunch();
        ExplosionSound();
    }

    private void DeathPunch()
    {
        EnemyHP -= 1;
        Tuch();
        if (EnemyHP == 0)
        {
            GetComponent<MeshRenderer>().enabled = false;


            Destroy(this.gameObject);

            sc.ScoreIncrease(balls);

            ExplosionON();

        }
    }

    void Tuch()
    {
        GameObject  boxPrefubs =Instantiate(point, transform.position, Quaternion.identity);
        boxPrefubs.transform.parent = boxPrefub;
    }
    void ExplosionON()
    {
       GameObject boxPrefubs = Instantiate(enemyExplosion, transform.position, Quaternion.identity);
        boxPrefubs.transform.parent = boxPrefub;
    }

    void ExplosionSound()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
    }
}
