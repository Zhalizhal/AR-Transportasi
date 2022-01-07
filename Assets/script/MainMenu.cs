using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //codingan pada tombol yang ada menu utama untuk berpindah scene
    //scene AR
    public void Ar(string scene_name)
    {
        //memanggil sound
        // AudioSource buttonSound = buttonSound.GetCoponent<AudioSource>();
        // buttonSound.PlayOneShot(buttonSound.clip);
        //Application.LoadLevel(scene_name);
        StartCoroutine(delay(scene_name));
    }

    //scene Kuis
    public void Kuis(string scene_name)
    {
        //Application.LoadLevel(scene_name);
        StartCoroutine(delay(scene_name));
    }
    //fungsi untuk keluar aplikasi
    public void Keluar()
    {
        Debug.Log("Keluar!");
        Application.Quit();
    }
    // untuk tombol on/of backsound
    public void sound_volume(float volume)
    {
        PlayerPrefs.SetFloat("volume", volume);
    }

    IEnumerator delay(string scene_name)
    {

        yield return new WaitForSeconds(1);
        Application.LoadLevel(scene_name);
    }
}
