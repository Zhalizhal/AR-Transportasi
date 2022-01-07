using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kuis : MonoBehaviour
{
    //untuk tombol kembali
    public void kembali(string scene_name)
    {
        Application.LoadLevel(scene_name);
    }

    //untuk tombol lanjut ke halaman soal
    public void Soal(string scene_name)
    {
        Application.LoadLevel(scene_name);
    }
}
