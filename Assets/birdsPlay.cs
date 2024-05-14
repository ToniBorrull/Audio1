using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdsPlay : MonoBehaviour
{
    public AudioSource aS;
    public float randomDelay;
    // Start is called before the first frame update
    void Start()
    {
        randomDelay = Random.Range(0.0f, 2.0f);
        aS = GetComponent<AudioSource>();
        Invoke("PlayBirds", randomDelay);
    }



    void PlayBirds()
    {
        aS.Play();
    }
}
