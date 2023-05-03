using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioClip Clip;
    public AudioSource Source;
    
    // Start is called before the first frame update
    void Start()
    {
        Source.PlayOneShot(Clip, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
