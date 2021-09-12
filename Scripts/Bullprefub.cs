using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullprefub : MonoBehaviour
{
   [SerializeField] int speed = 10;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        Destroy(this.gameObject, 12);
    }
}
