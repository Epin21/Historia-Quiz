using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelanjutnya : MonoBehaviour
{
    public HALO HALO;
    public void LoadToScene(string key)
    {
        //Level Selanjutnya jadi Ke Unlock
        PlayerPrefs.SetInt(key, 1);
        HALO.LoadToScene("Level List");
    }
}