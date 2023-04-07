using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Language : MonoBehaviour
{
    // MAINMENU //

    public Text startGameButton;
    public Text rankButton;
    public Text quitButton;

    // RANK PANEL //

    public Text rankButtonBack;

    // LANGUAGE PANEL //

    public Text languageButtonBack;
    public Text hungarianButton;
    public Text englishButton;
    public Text germanButton;
    public Text SelectLanguageText;

    // INFO PANEL //

    public Text info;
    public Text infoBackButton;

    // OPTIONS PANEL //

    public Text languageButton;
    public Text muteButton;
    public Text rateButton;
    public Text optionBackButton;

    // BUDDY PANEL // 

    public Text selectBuddy;
    public Text buddyBackButton;

    // SUMMONERSPELL PANEL 1 // 

    public Text SelectFirstSpell;
    public Text healText;
    public Text igniteText;
    public Text ghostText;
    public Text flashText;
    public Text exhaustText;
    public Text SummonerPanel1BackButton;

    // SUMMONERSPELL PANEL 2 // 

    public Text SelectSecondSpell;
    public Text healText2;
    public Text igniteText2;
    public Text ghostText2;
    public Text flashText2;
    public Text exhaustText2;
    public Text SummonerPanel2BackButton;

    // BUDDY PASS PANEL //

    public Text textfirstPass;
    public Text textfirstPass2;
    public Text nextButton1;

    public Text textsecondPass;
    public Text textsecondPass2;
    public Text nextButton2;
    public Text Backbutton2;

    public Text textthirdPass;
    public Text textthirdPass2;
    public Text nextButton3;
    public Text Backbutton3;

    public Text textfourthPass;
    public Text textfourthPass2;
    public Text nextButton4;
    public Text Backbutton4;

    public Text textfifthPass;
    public Text Backbutton5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeText();
    }

    public void ChangeText()
    {
        if (DataController.Instance.language == 0)
        {
            // MAINMENU //
            startGameButton.text = "PLAY";
            rankButton.text = "RANK";
            quitButton.text = "QUIT";
            // RANK PANEL //
            rankButtonBack.text = "Back";
            // LANGUAGE PANEL //
            languageButtonBack.text = "Back";
            hungarianButton.text = "Hungarian";
            germanButton.text = "German";
            englishButton.text = "English";
            SelectLanguageText.text = "Select Your Language";
            // INFO PANEL //
            info.text = "Lore of League isn't endorsed by Riot Games and doesn't reflect the views or opinions of Riot Games or anyone officially involved in producing or managing Riot Games properties. Riot Games, and all associated properties are trademarks or registered trademarks of Riot Games, Inc.";
            infoBackButton.text = "Back";
            // OPTIONS PANEL //
            languageButton.text = "Language";
            muteButton.text = "Mute";
            rateButton.text = "Rate";
            optionBackButton.text = "Back";
            // BUDDY PANEL // 
            buddyBackButton.text = "Back";
            selectBuddy.text = "Select Your Buddy";
            // SUMMONERSPELL PANEL 1 // 
            SelectFirstSpell.text = "Select Your First Spell";
            healText.text = "Use for +10 sec";
            igniteText.text = "Burn up a question";
            ghostText.text = "Stop the time for 10 sec";
            flashText.text = "Flash a question";
            exhaustText.text = "Decelerate the time";
            SummonerPanel1BackButton.text = "Back";
            // SUMMONERSPELL PANEL 2 // 
            SelectSecondSpell.text = "Select Your Second Spell";
            healText2.text = "Use for +10 sec";
            igniteText2.text = "Burn up a question";
            ghostText2.text = "Stop the time for 10 sec";
            flashText2.text = "Flash a question";
            exhaustText2.text = "Decelerate the time";
            SummonerPanel2BackButton.text = "Back";
            // BUDDY PASS PANEL //
            textfirstPass.text = "Iron";
            textfirstPass2.text = "Bronze";
            nextButton1.text = "Next";
            textsecondPass.text = "Silver";
            textsecondPass2.text = "Gold";
            nextButton2.text = "Next";
            Backbutton2.text = "Back";
            textthirdPass.text = "Platinum";
            textthirdPass2.text = "Diamond";
            nextButton3.text = "Next";
            Backbutton3.text = "Back";
            textfourthPass.text = "Master";
            textfourthPass2.text = "Grandmaster";
            nextButton4.text = "Next";
            Backbutton4.text = "Back";
            textfifthPass.text = "Challenger";
            Backbutton5.text = "Back";
}
        if (DataController.Instance.language == 1)
        {
            // MAINMENU //
            startGameButton.text = "JÁTÉK";
            rankButton.text = "RANG";
            quitButton.text = "KILÉPÉS";
            // RANK PANEL //
            rankButtonBack.text = "Vissza";
            // LANGUAGE PANEL //
            languageButtonBack.text = "Vissza";
            hungarianButton.text = "Magyar";
            germanButton.text = "Német";
            englishButton.text = "Angol";
            SelectLanguageText.text = "Válassz nyelvet";
            // INFO PANEL //
            info.text = "Lore of League isn't endorsed by Riot Games and doesn't reflect the views or opinions of Riot Games or anyone officially involved in producing or managing Riot Games properties. Riot Games, and all associated properties are trademarks or registered trademarks of Riot Games, Inc.";
            infoBackButton.text = "Vissza";
            // OPTIONS PANEL //
            languageButton.text = "Nyelv";
            muteButton.text = "Némítás";
            rateButton.text = "Értékeld!";
            optionBackButton.text = "Vissza";
            // BUDDY PANEL // 
            buddyBackButton.text = "Vissza";
            selectBuddy.text = "Válaszd ki a haverod";
            // SUMMONERSPELL PANEL 1 // 
            SelectFirstSpell.text = "Válaszd ki az első varázslatod";
            healText.text = "Adj még 10 mp-et az időhöz";
            igniteText.text = "Égess el egy kérdést";
            ghostText.text = "Állítsd meg az időt 10mp-re";
            flashText.text = "Villanj át egy kérdésen";
            exhaustText.text = "Lassítsd le az időt";
            SummonerPanel1BackButton.text = "Vissza";
            // SUMMONERSPELL PANEL 2 // 
            SelectSecondSpell.text = "Válaszd ki a második varázslatod";
            healText2.text = "Adj még 10 mp-et az időhöz";
            igniteText2.text = "Égess el egy kérdést";
            ghostText2.text = "Állítsd meg az időt 10mp-re";
            flashText2.text = "Villanj át egy kérdésen";
            exhaustText2.text = "Lassítsd le az időt";
            SummonerPanel2BackButton.text = "Vissza";
            // BUDDY PASS PANEL //
            textfirstPass.text = "Vas";
            textfirstPass2.text = "Bronz";
            nextButton1.text = "Következő";
            textsecondPass.text = "Ezüst";
            textsecondPass2.text = "Arany";
            nextButton2.text = "Következő";
            Backbutton2.text = "Vissza";
            textthirdPass.text = "Platina";
            textthirdPass2.text = "Gyémánt";
            nextButton3.text = "Következő";
            Backbutton3.text = "Vissza";
            textfourthPass.text = "Mester";
            textfourthPass2.text = "Nagymester";
            nextButton4.text = "Következő";
            Backbutton4.text = "Vissza";
            textfifthPass.text = "Kihívó";
            Backbutton5.text = "Vissza";
        }
    }
    public void HungarianLanguage()
    {
        DataController.Instance.language = 1;
        DataController.Instance.Save();
    }
    public void EnglishLanguage()
    {
        DataController.Instance.language = 0;
        DataController.Instance.Save();
    }
}
