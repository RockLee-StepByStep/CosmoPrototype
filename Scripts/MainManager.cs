using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MainManager : MonoBehaviour
{
    private bool isGameOver;
    public bool IsGameOver
    {
        get
        {
            return isGameOver;
        }
        set
        {
            if (CameraMove.Health < 0)
            {
                
                isGameOver = true;
            }
            isGameOver = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver == true)
        {
            Debug.Log("GameOver");
        }
    }
}
