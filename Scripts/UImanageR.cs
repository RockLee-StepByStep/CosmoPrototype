using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UImanageR : MonoBehaviour
{
    public Text activeText;
    //public Text HealthText;
    public TMP_Text textTMP;

    void Start()
    {
        //HealthText.text = "Health : " + CameraMove.Health;
        // textTMP = GameObject.FindObjectOfType<TMP_Text>();
       textTMP.text = "Health : " + CameraMove.Health;
    }

    public void ActivEnemyText()
    {
        activeText.text = "Active Enemyes : " + SpawnerManager.enemyCount;
    }

    public void HealthTextOn()
    {
       // HealthText.text = "Health : " + CameraMove.Health;
       textTMP.text = "Health : " + CameraMove.Health;
    }
}
