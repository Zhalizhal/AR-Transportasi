using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jawaban : MonoBehaviour
{
    public GameObject res_benar, res_salah;
    void Start()
    {

    }
    // codingan untuk jawaban
    // dengan kondisi ketika jawaban yang dipilih benar maka akan pindah ke frame selanjutnya dan frame sebelumnnya akan bersifat nonaktif
    // dan ketika masih dalam frame maka frme untuk soal lainnya bersifat nonaktif
    public void jawab(bool jawaban)
    {
        if (jawaban)
        {
            res_benar.SetActive(false);
            res_benar.SetActive(true);
            gameObject.SetActive(false);
            transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
        }
        else
        {
            res_salah.SetActive(false);
            res_salah.SetActive(true);
        }
    }
    void Update()
    {
        
    }
}
