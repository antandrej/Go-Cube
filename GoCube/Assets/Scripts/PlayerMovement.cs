using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public GameManager gameManager;
    public Text coinsCounter;
    public LevelChanger lvlChanger;
    public float speed;
    public float strafe;
    public bool alive;
    //public float jump;
    //public float jumpsLeft;
    public float coinsCount = 0;
    //public AudioClip coinSound;

    void Start()
    {
        rb.freezeRotation = false;
        alive = true;
    }

    void FixedUpdate()
    {       
        if (alive)
        {
            rb.AddForce(0, 0, speed);

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(-strafe, 0, 0);
            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(strafe, 0, 0);
            }
            /*
            if (jumpsLeft > 0)
            {
                if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
                {
                    rb.AddForce(0, jump, 0);
                    jumpsLeft--;
                    Debug.Log("jumps " + jumpsLeft);
                }
            }
            */
        }
        if (!alive)
            lvlChanger.FadeRestart();
            //StartCoroutine(gameManager.RestartLevel());
        coinsCounter.text = "coins: " + coinsCount;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obsticle")
        {
            alive = false;
        }
    }
    
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Ramp")
        {
            rb.freezeRotation = true;
        }

        if (alive)
        {
            if (collider.gameObject.tag == "Coin")
            {
                //AudioSource.PlayClipAtPoint(coinSound, collider.transform.position);                
                coinsCount++;
                Destroy(collider.gameObject);
            }
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Ramp")
        {
            rb.freezeRotation = false;           
        }
    }
}