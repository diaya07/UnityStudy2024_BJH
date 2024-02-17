using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletSpawner : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletTransform;
    public float spawnTime = 3;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnBullet());
    }

    IEnumerator spawnBullet()
    {
        while (true)
        {
            GameObject enemyBullet = Instantiate(bullet, bulletTransform.position, Quaternion.identity);
            EnemyBullet theEnemyBullet = enemyBullet.GetComponent<EnemyBullet>();
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
