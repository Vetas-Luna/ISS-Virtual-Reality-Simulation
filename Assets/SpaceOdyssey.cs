using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SpaceOdyssey : MonoBehaviour
{
    public AudioSource myAudio;
    public ActionBasedContinuousMoveProvider CMProvider;
    public Rigidbody RBody;
    // Start is called before the first frame update
    void Start()
    {
        if (myAudio.isPlaying)
        {
            myAudio.Stop();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (!myAudio.isPlaying)
        {
            
            myAudio.Play(0);
            StartCoroutine(StopAndFly());
        }
    }

    IEnumerator StopAndFly()
    {
        yield return new WaitForSeconds(52);
        CMProvider.enabled = true;
        CMProvider.enableFly = true;
        RBody.velocity = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
