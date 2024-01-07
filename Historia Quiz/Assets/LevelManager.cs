using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public Button buttonChooseAnswer2;
    public Button buttonChooseAnswer3;
    public Button buttonChooseAnswer4;
    public Button buttonChooseAnswer5;
    public Button buttonChooseAnswer6;
    public Button buttonChooseAnswer7;
    public Button buttonChooseAnswer8;
    public Button buttonChooseAnswer9;
    public Button buttonChooseAnswer10;

    void Start()
    {
        CheckLevel();
    }

    public void CheckLevel()
    {
        int statusChooseAnswer2 = PlayerPrefs.GetInt("Choose Answer 2");
        int statusChooseAnswer3 = PlayerPrefs.GetInt("Choose Answer 3");
        int statusChooseAnswer4 = PlayerPrefs.GetInt("Choose Answer 4");
        int statusChooseAnswer5 = PlayerPrefs.GetInt("Choose Answer 5");
        int statusChooseAnswer6 = PlayerPrefs.GetInt("Choose Answer 6");
        int statusChooseAnswer7 = PlayerPrefs.GetInt("Choose Answer 7");
        int statusChooseAnswer8 = PlayerPrefs.GetInt("Choose Answer 8");
        int statusChooseAnswer9 = PlayerPrefs.GetInt("Choose Answer 9");
        int statusChooseAnswer10 = PlayerPrefs.GetInt("Choose Answer 10");

        if (statusChooseAnswer2 == 1)
            buttonChooseAnswer2.interactable = true;
        else
            buttonChooseAnswer2.interactable = false;

        if (statusChooseAnswer3 == 1)
            buttonChooseAnswer3.interactable = true;
        else
            buttonChooseAnswer3.interactable = false;

        if (statusChooseAnswer4 == 1)
            buttonChooseAnswer4.interactable = true;
        else
            buttonChooseAnswer4.interactable = false;

        if (statusChooseAnswer5 == 1)
            buttonChooseAnswer5.interactable = true;
        else
            buttonChooseAnswer5.interactable = false;

        if (statusChooseAnswer6 == 1)
            buttonChooseAnswer6.interactable = true;
        else
            buttonChooseAnswer6.interactable = false;

        if (statusChooseAnswer7 == 1)
            buttonChooseAnswer7.interactable = true;
        else
            buttonChooseAnswer7.interactable = false;

        if (statusChooseAnswer8 == 1)
            buttonChooseAnswer8.interactable = true;
        else
            buttonChooseAnswer8.interactable = false;

        if (statusChooseAnswer9 == 1)
            buttonChooseAnswer9.interactable = true;
        else
            buttonChooseAnswer9.interactable = false;

        if (statusChooseAnswer10 == 1)
            buttonChooseAnswer10.interactable = true;
        else
            buttonChooseAnswer10.interactable = false;
    }

    public void ResetLevel()
    {
        PlayerPrefs.DeleteKey("Choose Answer 2");
        PlayerPrefs.DeleteKey("Choose Answer 3");
        PlayerPrefs.DeleteKey("Choose Answer 4");
        PlayerPrefs.DeleteKey("Choose Answer 5");
        PlayerPrefs.DeleteKey("Choose Answer 6");
        PlayerPrefs.DeleteKey("Choose Answer 7");
        PlayerPrefs.DeleteKey("Choose Answer 8");
        PlayerPrefs.DeleteKey("Choose Answer 9");
        PlayerPrefs.DeleteKey("Choose Answer 10");

        CheckLevel();
    }


    //Level2 
    //Level3
    //1 == Unlock
    //0 == Lock
}