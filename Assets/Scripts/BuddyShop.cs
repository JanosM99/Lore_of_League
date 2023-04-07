using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuddyShop : MonoBehaviour
{
    public Sprite buddy1;
    public Sprite buddy2;
    public Sprite buddy3;
    public Sprite buddy4;
    public Sprite buddy5;
    public Sprite buddy6;
    public Sprite buddy7;

    public Button BuddyButton;


    public AudioClip notEnoughCurrency;
    public AudioClip buySound;

    public MainMenu mainMenuScript;
    // Start is called before the first frame update
    void Start()
    {
        mainMenuScript = GameObject.Find("MenuScreenController").GetComponent<MainMenu>();
    }

    // Update is called once per frame
    void Update()
    {
        CurrentBuddyScript();
        mainMenuScript.currencyText.text = " " + DataController.Instance.currency.ToString();
    }

    public void BuyBuddy1()
    {
        if(DataController.Instance.currency < 25)
        {
            mainMenuScript.MenuSource.PlayOneShot(notEnoughCurrency, 1.0f);
        }
        else
        {
            DataController.Instance.buddy = 1;
            DataController.Instance.currency -= 25;
            DataController.Instance.Save();
            mainMenuScript.MenuSource.PlayOneShot(buySound, 1.0f);
        }

    }

    public void BuyBuddy2()
    {
        if(DataController.Instance.currency < 25)
        {
            mainMenuScript.MenuSource.PlayOneShot(notEnoughCurrency, 1.0f);
        }
        else
        {
            DataController.Instance.buddy = 2;
            DataController.Instance.currency -= 25;
            DataController.Instance.Save();
            mainMenuScript.MenuSource.PlayOneShot(buySound, 1.0f);
        }

    }
    public void BuyBuddy3()
    {
        if (DataController.Instance.currency < 25)
        {
            mainMenuScript.MenuSource.PlayOneShot(notEnoughCurrency, 1.0f);
        }
        else
        {
            DataController.Instance.buddy = 3;
            DataController.Instance.currency -= 25;
            DataController.Instance.Save();
            mainMenuScript.MenuSource.PlayOneShot(buySound, 1.0f);
        }

    }
    public void BuyBuddy4()
    {
        if(DataController.Instance.currency < 50)
        {
            mainMenuScript.MenuSource.PlayOneShot(notEnoughCurrency, 1.0f);
        }
        else
        {
            DataController.Instance.buddy = 4;
            DataController.Instance.currency -= 50;
            DataController.Instance.Save();
            mainMenuScript.MenuSource.PlayOneShot(buySound, 1.0f);
        }
    }
    public void BuyBuddy5()
    {
        if (DataController.Instance.currency < 50)
        {
            mainMenuScript.MenuSource.PlayOneShot(notEnoughCurrency, 1.0f);
        }
        else
        {
            DataController.Instance.buddy = 5;
            DataController.Instance.currency -= 50;
            DataController.Instance.Save();
            mainMenuScript.MenuSource.PlayOneShot(buySound, 1.0f);
        }
    }
    public void BuyBuddy6()
    {
        if (DataController.Instance.currency < 50)
        {
            mainMenuScript.MenuSource.PlayOneShot(notEnoughCurrency, 1.0f);
        }
        else
        {
            DataController.Instance.buddy = 6;
            DataController.Instance.currency -= 50;
            DataController.Instance.Save();
            mainMenuScript.MenuSource.PlayOneShot(buySound, 1.0f);
        }
    }
    public void BuyBuddy7()
    {
        if (DataController.Instance.currency < 50)
        {
            mainMenuScript.MenuSource.PlayOneShot(notEnoughCurrency, 1.0f);
        }
        else
        {
            DataController.Instance.buddy = 7;
            DataController.Instance.currency -= 50;
            DataController.Instance.Save();
            mainMenuScript.MenuSource.PlayOneShot(buySound, 1.0f);
        }
    }
    public void CurrentBuddyScript()
    {
        if(DataController.Instance.buddy == 1)
        {
            BuddyButton.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = buddy1;
        }
        if (DataController.Instance.buddy == 2)
        {
            BuddyButton.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = buddy2;
        }
        if (DataController.Instance.buddy == 3)
        {
            BuddyButton.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = buddy3;
        }
        if (DataController.Instance.buddy == 4)
        {
            BuddyButton.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = buddy4;
        }
        if (DataController.Instance.buddy == 5)
        {
            BuddyButton.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = buddy5;
        }
        if (DataController.Instance.buddy == 6)
        {
            BuddyButton.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = buddy6;
        }
        if (DataController.Instance.buddy == 7)
        {
            BuddyButton.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = buddy7;
        }
    }
}
