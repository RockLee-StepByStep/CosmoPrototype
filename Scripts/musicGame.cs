using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class musicGame : MonoBehaviour
{
   
    void Awake() // запускает процесс сначала игры и до конца сессии 
    {
        

        // находим и передаём переменной данные оъекта мюзик 
        int musicLine = FindObjectsOfType<musicGame>().Length;


        if (musicLine>1) //если появляется больше одного объекта с музыкой на нём мы просто уничтожаем новый объект 
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject); // к конце концов не уничтожай музыку после респауна уровня.
        }
    }
}
