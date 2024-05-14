using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stepsSound : MonoBehaviour
{
    public AudioSource aS;
    public AudioClip[] steps;
    public AudioClip[] waterSteps;

    public int type;

    public CapsuleCollider playerColl;
    // Start is called before the first frame update
    void Start()
    {
        aS = GetComponent<AudioSource>();
        playerColl = GetComponent<CapsuleCollider>();
        type = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Step()
    {
        if (type == 1) { 
            GrassStep();
        }
        if (type == 2)
        {
            WaterStep();
        }
    }

    void GrassStep() 
    {
        aS.clip = steps[Random.Range(0, steps.Length)];
        aS.Play();
    
    }
    void WaterStep()
    {
            aS.clip = waterSteps[Random.Range(0, waterSteps.Length)];
            aS.Play();
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("water"))
        {
            type = 2;
        }
        if (other.gameObject.CompareTag("grass"))
        {
            type = 1;
        }

    }
}
