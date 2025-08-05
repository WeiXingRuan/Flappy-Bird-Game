using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float flyPower;
    public GameObject gameController;

    public AudioClip flyUp;
    public AudioClip flyDown;
    public AudioClip hitClip;

    public AudioClip gameOverClip;
    public AudioSource audioSource;
    public AudioSource audioAdd;

    // Start is called before the first frame update
    void Start()
    {
        flyPower = 10;

        audioSource = GetComponent<AudioSource>();
        audioAdd = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            audioSource.clip = flyUp;
            if (gameController.GetComponent<GameController>().isStart)
            {
                audioSource.Play();
            }
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyPower));
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        EndGame();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        gameController.GetComponent<GameController>().GetPoint();
    }
    void EndGame()
    {
        audioSource.clip = gameOverClip;
        audioSource.Play();

        gameController.GetComponent<GameController>().EndGame();


    }

}