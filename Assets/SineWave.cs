using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineWave : MonoBehaviour
{
    //range.if its 3 it will be between 3 and -3
    private int amplitude;

    //speed
    private float frequency;
    
    
    // Update is called once per frame
    void Update()
    {

        float x = transform.position.x;  //if its cosx the shape will be circle
        float y = Mathf.Sin(Time.time * frequency) * amplitude;
        float z = transform.position.z;
        
        transform.position = new Vector3(x,y,z);

    }
}
