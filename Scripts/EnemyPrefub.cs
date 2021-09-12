using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPrefub : MonoBehaviour
{

    private UImanageR UImanageR;


    public void OnEnable()
    {
        SpawnerManager.enemyCount++;
        Destroy(this.gameObject, Random.Range(1, 9));
        UImanageR = GameObject.Find("UI_manager").GetComponent<UImanageR>();
        UImanageR.ActivEnemyText();
    }

    private void OnDisable()
    {
        SpawnerManager.enemyCount--;
        UImanageR.ActivEnemyText();
    }

}
