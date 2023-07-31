    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPrototype4 : MonoBehaviour
{
    public float speed = 3f;
    private Rigidbody enemyRb;
    private GameObject player;
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 LookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(LookDirection * speed);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
