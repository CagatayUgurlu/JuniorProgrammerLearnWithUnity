using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft4 : MonoBehaviour
{
    public float speed = 30f;
    private PlayerController4 playerController4Script;
    void Start()
    {
        playerController4Script = GameObject.Find("Player").GetComponent<PlayerController4>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController4Script.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

    }
}
