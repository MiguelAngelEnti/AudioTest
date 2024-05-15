using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityMusic : MonoBehaviour
{
    public AudioClip music;
    public AudioSource source;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            source.clip = music;
            if (!source.isPlaying)
            {
                source.Play();
            }
        }
    }
}
