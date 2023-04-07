using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class SummonerSpellScript : MonoBehaviour
{
    public AudioClip SpellSelectSound;
    public AudioClip SpellSameSelectSound;

    public MainMenu MainMenuScript;


    public Button heal;
    public Button ignite;
    public Button ghost;
    public Button flash;
    public Button exhaust;

    public Button heal2;
    public Button ignite2;
    public Button ghost2;
    public Button flash2;
    public Button exhaust2;

    public int healSpell = 1;
    public int igniteSpell = 2;
    public int ghostSpell = 3;
    public int flashSpell = 4;
    public int exhaustSpell = 5;

    // Start is called before the first frame update
    void Start()
    {
        MainMenuScript = GameObject.Find("MenuScreenController").GetComponent <MainMenu>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // BUTTON 1 //
    public void healButton1Pressed()
    {
        if (DataController.Instance.summonerSpell2 != 1)
        {
            DataController.Instance.summonerSpell1 = 1;
            MainMenuScript.MenuSource.PlayOneShot(SpellSelectSound, 1.0f);
            DataController.Instance.Save();
        }
        else
        {
            MainMenuScript.MenuSource.PlayOneShot(SpellSameSelectSound, 1.0f);
        }
    }
    public void igniteButton1Pressed()
    {
        if(DataController.Instance.summonerSpell2 != 2)
        {
            DataController.Instance.summonerSpell1 = 2;
            MainMenuScript.MenuSource.PlayOneShot(SpellSelectSound, 1.0f);
            DataController.Instance.Save();
        }
        else
        {
            MainMenuScript.MenuSource.PlayOneShot(SpellSameSelectSound, 1.0f);
        }
    }
    public void ghostButton1Pressed()
    {
        if(DataController.Instance.summonerSpell2 != 3)
        {
            DataController.Instance.summonerSpell1 = 3;
            MainMenuScript.MenuSource.PlayOneShot(SpellSelectSound, 1.0f);
            DataController.Instance.Save();
        }
        else
        {
            MainMenuScript.MenuSource.PlayOneShot(SpellSameSelectSound, 1.0f);
        }

    }
    public void flashButton1Pressed()
    {
        if(DataController.Instance.summonerSpell2 != 4)
        {
            DataController.Instance.summonerSpell1 = 4;
            MainMenuScript.MenuSource.PlayOneShot(SpellSelectSound, 1.0f);
            DataController.Instance.Save();
        }
        else
        {
            MainMenuScript.MenuSource.PlayOneShot(SpellSameSelectSound, 1.0f);
        }

    }
    public void exhaustButton1Pressed()
    {
        if(DataController.Instance.summonerSpell2 != 5)
        {
            DataController.Instance.summonerSpell1 = 5;
            MainMenuScript.MenuSource.PlayOneShot(SpellSelectSound, 1.0f);
            DataController.Instance.Save();
        }
        else
        {
            MainMenuScript.MenuSource.PlayOneShot(SpellSameSelectSound, 1.0f);
        }

    }

    // BUTTON 2 //

    public void healButton2Pressed()
    {
        if(DataController.Instance.summonerSpell1 != 1)
        {
            DataController.Instance.summonerSpell2 = 1;
            MainMenuScript.MenuSource.PlayOneShot(SpellSelectSound, 1.0f);
            DataController.Instance.Save();
        }
        else
        {
            MainMenuScript.MenuSource.PlayOneShot(SpellSameSelectSound, 1.0f);
        }
    }
    public void igniteButton2Pressed()
    {
        if(DataController.Instance.summonerSpell1 != 2)
        {
            DataController.Instance.summonerSpell2 = 2;
            MainMenuScript.MenuSource.PlayOneShot(SpellSelectSound, 1.0f);
            DataController.Instance.Save();
        }
        else
        {
            MainMenuScript.MenuSource.PlayOneShot(SpellSameSelectSound, 1.0f);
        }
    }
    public void ghostButton2Pressed()
    {
        if(DataController.Instance.summonerSpell1 != 3)
        {
            DataController.Instance.summonerSpell2 = 3;
            MainMenuScript.MenuSource.PlayOneShot(SpellSelectSound, 1.0f);
            DataController.Instance.Save();
        }
        else
        {
            MainMenuScript.MenuSource.PlayOneShot(SpellSameSelectSound, 1.0f);
        }
    }
    public void flashButton2Pressed()
    {
        if(DataController.Instance.summonerSpell1 != 4)
        {
            DataController.Instance.summonerSpell2 = 4;
            MainMenuScript.MenuSource.PlayOneShot(SpellSelectSound, 1.0f);
            DataController.Instance.Save();
        }
        else
        {
            MainMenuScript.MenuSource.PlayOneShot(SpellSameSelectSound, 1.0f);
        }
    }
    public void exhaustButton2Pressed()
    {
        if(DataController.Instance.summonerSpell1 != 5)
        {
            DataController.Instance.summonerSpell2 = 5;
            MainMenuScript.MenuSource.PlayOneShot(SpellSelectSound, 1.0f);
            DataController.Instance.Save();
        }
        else
        {
            MainMenuScript.MenuSource.PlayOneShot(SpellSameSelectSound, 1.0f);
        }
    }

}
