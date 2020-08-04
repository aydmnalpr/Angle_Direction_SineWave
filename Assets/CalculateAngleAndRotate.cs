using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateAngleAndRotate : MonoBehaviour
{
    private Transform enemy;
    
   
    void Update()
    {
        Vector3 direction = enemy.position - transform.position;

        //calculate angle, convert to deg and minus offset
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90.0f;
        
        //store rotation axis and angle in quaternion
        Quaternion angleAxis = Quaternion.AngleAxis(angle, Vector3.forward);

        transform.rotation = Quaternion.Slerp(transform.rotation, angleAxis, Time.deltaTime * 50);
        
        //same
        //transform.eulerAngles = Vector3.forward * angle

    }
}
