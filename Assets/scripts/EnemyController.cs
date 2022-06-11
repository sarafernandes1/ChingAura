using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    public Transform Player;
    int MoveSpeed = 4;
    int MaxDist = 10;
    int MinDist = 3;
    public MeshRenderer modelo;
    public Collider poder;

    void Start()
    {

    }

    void Update()
    {
       
        if (poder==null)
        {
            modelo.enabled = true;
            transform.LookAt(Player);
            
            if (Vector3.Distance(transform.position, Player.position) >= MinDist)
            {
                transform.position += transform.forward * MoveSpeed * Time.deltaTime;

            }
        }
    }
}