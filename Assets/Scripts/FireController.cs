using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using Random = UnityEngine.Random;

public class FireController : MonoBehaviour
{
    public float upSpeed; // fire up speed

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 7f)
        {
            SceneManager.LoadScene("Level1"); // reload the level
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(0, upSpeed, 0); // moving fire upwards
    }

    private void OnMouseDown()
    {
        GameManager.instance.Score++; // increasing score.
        
        audioSource.Play();
        
        ResetPosition();
    }

    private void ResetPosition()
    {
        float randomX = Random.Range(-7f, 7f); // just hard coding position for fire randomness.

        transform.position = new Vector2(randomX, -7f);

    }
}
