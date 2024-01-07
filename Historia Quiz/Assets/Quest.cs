using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Quest : MonoBehaviour
{
    public Text soalText;
    public Text[] jawabanTexts;

    public ControlQuest controlQuest;
    int nomerSoal;

    public GameObject panelHasil;
    
    // Start is called before the first frame update
    void Start()
    {
        GenerateQuest();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GenerateQuest()
    {
        soalText.text = controlQuest.soals[nomerSoal].elementSoal.soal;

        for(int i =0; i < jawabanTexts.Length; i++)
        {
            jawabanTexts[i].text = controlQuest.soals[nomerSoal].elementSoal.jawabans[i];
        }
    }

    public void ButtonJawabanSoal()
    {
        Text currentJawaban = EventSystem.current.currentSelectedGameObject.transform.GetChild(0).GetComponent<Text>();

        if (currentJawaban.text == controlQuest.soals[nomerSoal].elementSoal.jawabans[controlQuest.soals[nomerSoal].elementSoal.jawabanBenar]) // 0 1 2 3 jawabanBenar = 3
        {
            Debug.Log("benar");

            panelHasil.transform.GetChild(1).gameObject.SetActive(false);
            
        }
        else
        {
            Debug.Log("salah");

            panelHasil.transform.GetChild(0).gameObject.SetActive(false);
        }
        
        panelHasil.SetActive(true);
    }
}
