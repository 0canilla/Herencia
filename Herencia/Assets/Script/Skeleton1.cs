using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton1 : Skeleton
{
    public float enemySpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        MoveTowards();
    }

    private void MoveTowards()
    {
        Vector3 direction = (Player.transform.position - transform.position).normalized;
        transform.position += enemySpeed * direction * Time.deltaTime;
    }
}
