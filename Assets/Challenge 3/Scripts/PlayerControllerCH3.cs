using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerCH3 : MonoBehaviour
{
    public bool gameOver;


    public float floatForce = 15f;
    private float gravityModifier = 1.5f;
    private Rigidbody playerRb;

    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;

    private AudioSource playerAudio;
    public AudioClip moneySound;
    public AudioClip explodeSound;
    public AudioClip wrongWaySound;

    public bool isLowEnough = false;
    public bool isHighEnough = false;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();

        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        // While space is pressed and player is low enough, float up
        if (Input.GetKey(KeyCode.Space) && !gameOver && transform.position.y < 15)
        {
            playerRb.AddForce(Vector3.up * floatForce);
        }
      /*  if (transform.position.y > 15)
        {
            playerAudio.PlayOneShot(wrongWaySound);
        }
      */
    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        } 


        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            fireworksParticle.Play();
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);

        }

        if (other.gameObject.CompareTag("Ground"))
        {
            _ = isLowEnough == true;
            playerAudio.PlayOneShot(wrongWaySound);
            playerRb.AddForce(Vector3.up * 500);
        }
        if (other.gameObject.CompareTag("Top"))
        {
            _ = isHighEnough == true;
            playerAudio.PlayOneShot(wrongWaySound);
            playerRb.AddForce(Vector3.down * 500);
        }

    }

}
