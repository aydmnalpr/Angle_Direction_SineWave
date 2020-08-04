using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateDirection : MonoBehaviour
{
    private Vector3 direction;
    private Transform player;

    [SerializeField]
    private float speed;
    void Update()
    {
        direction = player.position - transform.position;

        direction.normalized;
        
        transform.Translate(direction * Time.deltaTime * speed);
    }
}
