using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{
    public bool hit;

    void Update()
    {
        hit = Physics.Raycast(transform.position, transform.forward, 5f);
        Debug.DrawRay(transform.position, transform.forward * 5, Color.red);

        if (hit == true)
             {
                 Debug.LogWarning("be careful!");
             } else {
                Debug.Log("all clear!");
             }
    }   
}
