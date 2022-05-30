using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(AudioSource))]
public class Sound : MonoBehaviour
{
    [SerializeField] 
    private List<AudioClip> speech;

    private AudioClip nextClip;
    private int clipIndex;

    private AudioSource aSource;
    
    [SerializeField] 
    private Punkte punkteScript;
    void Start()
    {
        aSource = GetComponent<AudioSource>();
        clipIndex = 0;
        //aSource.clip = speech[clipIndex];
        //aSource.Play();

        StartCoroutine(playSounds());
    }

    private void Update()
    {
        //PlayNext();
    }

    private void PlayNext()
    {
        aSource.clip = speech[clipIndex];
        aSource.Play();
        if (!aSource.isPlaying)
        {
            clipIndex++;
        }
        
    }

 
    IEnumerator playSounds()
    {
        aSource.clip = speech[clipIndex];
        aSource.Play();
        yield return new WaitForSeconds(aSource.clip.length + 1f);
        
        clipIndex++;
        aSource.clip = speech[clipIndex];
        Debug.Log("Next Sound: " + aSource.clip.name);
        aSource.Play();
        yield return new WaitForSeconds(aSource.clip.length + 3f);
        
        punkteScript.pickPoints = true;
        clipIndex++;
        aSource.clip = speech[clipIndex];
        Debug.Log("Next Sound: " + aSource.clip.name);
        aSource.Play();
    }
}