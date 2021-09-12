using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class scorePoint : MonoBehaviour
{
    int score;

    TMP_Text tmpText;
 

    // Start is called before the first frame update
    void Start()
    {
        tmpText = GetComponent<TMP_Text>();
        


        
    }

    // Update is called once per frame
    void Update()
    {
        tmpText.text = ($"score:{score}");
    }
   
   public void ScoreIncrease(int punch)
    {
        score += punch;
        Debug.Log(score);
    }
}
