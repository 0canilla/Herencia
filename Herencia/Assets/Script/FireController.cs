using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    public float enemySpeed = 4;
    public GameObject Player;
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
