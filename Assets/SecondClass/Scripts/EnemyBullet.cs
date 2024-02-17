using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private float bulletSpeed;

    private Vector3 caulateDirection;

    void Start()
    {
        player = GameObject.Find("Player").transform;
        Vector3 playerDirection = new Vector3(player.position.x, 0, player.position.z);
        caulateDirection = (playerDirection - transform.position).normalized;
        caulateDirection.y = 0;
    }

    // Update is called once per frame
    void Update()
    {
        BulletMove();
    }

    private void BulletMove()
    {
        
        transform.position += bulletSpeed * caulateDirection * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("...");
    }
}
