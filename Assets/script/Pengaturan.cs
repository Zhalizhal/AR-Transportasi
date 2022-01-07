using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Pengaturan : MonoBehaviour
{
    // untuk pengaturan suara
    public AudioMixer audioMixer;
    public void SetVolume(float Suara)
    {
        audioMixer.SetFloat("Suara", Suara);
    }
}
