using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireOfSaund : MonoBehaviour
{
    AudioSource AudioSource;
    


    private void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    public void SwitchON()
        {
        AudioSource.enabled = true;
        }

    public void SwitchOFF()
    {
        AudioSource.enabled = false;
    }
}
