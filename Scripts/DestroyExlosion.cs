using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyExlosion : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        // уничтожаю объёект после его генерации спустя 2сек.
        Destroy(gameObject, 2f);
    }
}
