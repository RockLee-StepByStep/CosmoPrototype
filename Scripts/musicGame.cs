using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class musicGame : MonoBehaviour
{
   
    void Awake() // ��������� ������� ������� ���� � �� ����� ������ 
    {
        

        // ������� � ������� ���������� ������ ������ ����� 
        int musicLine = FindObjectsOfType<musicGame>().Length;


        if (musicLine>1) //���� ���������� ������ ������ ������� � ������� �� �� �� ������ ���������� ����� ������ 
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject); // � ����� ������ �� ��������� ������ ����� �������� ������.
        }
    }
}
