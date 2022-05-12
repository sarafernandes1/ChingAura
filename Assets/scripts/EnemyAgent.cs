using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAgent : MonoBehaviour
{
    public int hp;
    public int maxHp;
    public Collider player;

    void Start()
    {
    }

    public void GotShot(int damage)
    {
        hp -= damage;
        hp = Mathf.Clamp(hp, 0, maxHp);


        if (hp == 0)
        {
            Vector3 dir = transform.position - player.transform.position;

            //GameObject rd = Instantiate(ragdoll, transform.position, transform.rotation); //instancia ragdoll
            //rd.GetComponent<RagdollController>().ApplyForce(dir * 20f);

            Destroy(gameObject);
        }
    }
}
