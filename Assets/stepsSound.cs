using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stepsSound : MonoBehaviour
{
    public AudioSource aS;
    public AudioClip[] steps;
    // Start is called before the first frame update
    void Start()
    {
        aS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Step() {

        aS.clip = steps[Random.Range(0, steps.Length)];
       aS.Play();
    }
}
