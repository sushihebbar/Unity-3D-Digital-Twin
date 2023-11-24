using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource src;
    public AudioClip sfx1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playsound()
    {
        src.clip = sfx1;
        src.Play();
    }
}
