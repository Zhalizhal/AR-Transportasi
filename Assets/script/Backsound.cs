using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backsound : MonoBehaviour
{
    // musik akan dimulai pada saat menu utama dan memanggil musik dari file yang di inputkan di unity
    void Start()
    {
        if (GameObject.Find("backsound on")==null) {
            DontDestroyOnLoad(gameObject);
            GetComponent<AudioSource>().Play();
            gameObject.name = "backsound on";
            PlayerPrefs.SetFloat("volume", 0.100f);
        }
    }

    // musik akan lanjut pada setiap scene
    void Update()
    {
        GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("volume");
    }
}
