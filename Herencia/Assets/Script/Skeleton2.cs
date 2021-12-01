using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton2 : Skeleton
{
    public GameObject[] enemyPrefab;
    public GameObject ShootingPoint;
    // Start is called before the first frame update
    void Start()
    {
        ShootingPoint = GameObject.Find("ShootingPoint");
        InvokeRepeating("spawnEnemy", 2f, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnEnemy()
    {
        int enemyIndex = Random.Range(0, enemyPrefab.Length);
        Instantiate(enemyPrefab[enemyIndex], ShootingPoint.transform.position, Quaternion.identity);
    }


}
