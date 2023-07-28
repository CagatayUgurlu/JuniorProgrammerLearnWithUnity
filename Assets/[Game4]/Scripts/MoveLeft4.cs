using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveLeft4 : MonoBehaviour
{
    public float speed = 30f;
    private PlayerController4 playerController4Script;
    private float leftBound = -10f;
    void Start()
    {
        playerController4Script = GameObject.Find("Player").GetComponent<PlayerController4>();
    }

    // Update is called once per frame
    void Update()
    {
       /*if (!playerController4Script.gameOver)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
       */
        if (!playerController4Script.gameOver)
        {
            if (playerController4Script.doubleSpeed)
            {
                transform.Translate(Vector3.left * Time.deltaTime * (speed *2 ));
            }
            else
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
        }
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacles"))
        {
            Destroy(gameObject);
        }

    }
}
