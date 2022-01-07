using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AR : MonoBehaviour
{
    //untuk kembali pada scene sebelumnnya
    public void kembali(string scene_name)
    {
        Application.LoadLevel(scene_name);
    }
}
