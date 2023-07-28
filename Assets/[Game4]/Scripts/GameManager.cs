using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float score;
    private PlayerController4 playerController4Script;

    void Start()
    {
        playerController4Script = GameObject.Find("Player").GetComponent<PlayerController4>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(!playerController4Script.gameOver)
        {
            if (playerController4Script.doubleSpeed)
            {
                score += 2;
            }
            else
            {
                score++;
            }
        }
    }
}
