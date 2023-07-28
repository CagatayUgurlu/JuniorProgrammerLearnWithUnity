using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform startingPoint;
    public float score;
    public float lerpSpeed;
    private PlayerController4 playerController4Script;

    void Start()
    {
        playerController4Script = GameObject.Find("Player").GetComponent<PlayerController4>();
        score = 0;

        playerController4Script.gameOver = true;
        StartCoroutine(PlayIntro());
    }

    // Update is called once per frame
    void Update()
    {
        ScoreManager();

    }

    private void ScoreManager()
    {
        if (!playerController4Script.gameOver)
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

    IEnumerator PlayIntro()
    {
        Vector3 startPos = playerController4Script.transform.position;
        Vector3 endPos = startingPoint.position;
        float journeyLength = Vector3.Distance(startPos, endPos);
        float startTime = Time.time;

        float distanceCovered = (Time.time - startTime) * lerpSpeed;
        float fractionOfJourney = distanceCovered / journeyLength;

        playerController4Script.GetComponent<Animator>().SetFloat("Speed_Multiplier", 0.5f);

        while (fractionOfJourney < 1)
        {
            distanceCovered = (Time.time - startTime) * lerpSpeed;
            fractionOfJourney = distanceCovered / journeyLength;
            playerController4Script.transform.position = Vector3.Lerp(startPos, endPos, fractionOfJourney);
            yield return null;
        }

        playerController4Script.GetComponent<Animator>().SetFloat("Speed_Multiplier", 1.0f);
        playerController4Script.gameOver = false;

    }

}
