using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageGame : MonoBehaviour
{

    // QUESTIONPANEL //
    public Text helpButton;

    // ROUNDOVER PANEL //
    public Text menuButton;

    // HINT PANEL //
    public Text backButton;

    // HELP PANEL //
    public Text backButton2;
    public Text watchADS;
    public Text notenough;
    public Text notenough2;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeTextInGame();
    }

    public void ChangeTextInGame()
    {
        if(DataController.Instance.language == 0)
        {
            helpButton.text = "Help";
            menuButton.text = "MENU";
            backButton.text = "Back";
            backButton2.text = "Back";
            watchADS.text = "Watch ADS";
            notenough.text = "Not enough";
            notenough2.text = "Watch ADS!";
        }
        if(DataController.Instance.language == 1)
        {
            helpButton.text = "Segítség";
            menuButton.text = "MENÜ";
            backButton.text = "Vissza";
            backButton2.text = "Vissza";
            watchADS.text = "Nézz reklámot";
            notenough.text = "Nincs elég";
            notenough2.text = "Nézz reklámot!";
        }
    }

}
