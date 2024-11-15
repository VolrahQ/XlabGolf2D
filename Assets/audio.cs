using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    private AudioSource _audioSource;
    private void Awake()
    {
     _audioSource = GetComponent<AudioSource>();
    }
    public void ClickSound()
    {
        _audioSource.Play();
    }
}
