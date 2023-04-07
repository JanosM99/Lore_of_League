using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankSystem : MonoBehaviour
{
    public GameObject rank;

    public Text rankText;

    public Sprite Unranked;
    public Sprite Iron;
    public Sprite Bronze;
    public Sprite Silver;
    public Sprite Gold;
    public Sprite Platinum;
    public Sprite Diamond;
    public Sprite Master;
    public Sprite Grandmaster;
    public Sprite Challenger;

    public Button buddyPassIron;
    public Button buddyPassBronze;
    public Button buddyPassSilver;
    public Button buddyPassGold;
    public Button buddyPassPlatinum;
    public Button buddyPassDiamond;
    public Button buddyPassMaster;
    public Button buddyPassGrandmaster;
    public Button buddyPassChallenger;




    private static RankSystem instance;
    public static RankSystem Instance { get { return instance; } }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        RankSystemScript();
        buddyPassInteractable();
    }

    public void RankSystemScript()
    {
        if (DataController.Instance.rankPoint <= 10)
        {
            if (DataController.Instance.language == 0)
            {
                rankText.text = "Unranked";
                rank.GetComponent<UnityEngine.UI.Image>().overrideSprite = Unranked;
            }
            if(DataController.Instance.language == 1)
            {
                rankText.text = "Unranked";
                rank.GetComponent<UnityEngine.UI.Image>().overrideSprite = Unranked;
            }
        }
        if (DataController.Instance.rankPoint >= 11 && DataController.Instance.rankPoint <= 15)
        {
            buddyPassIron.interactable = true;
            if (DataController.Instance.language == 0)
            {
                rankText.text = "Iron";
                rank.GetComponent<UnityEngine.UI.Image>().overrideSprite = Iron;
            }
            if(DataController.Instance.language == 1)
            {
                rankText.text = "Vas";
                rank.GetComponent<UnityEngine.UI.Image>().overrideSprite = Iron;
            }
        }
        if (DataController.Instance.rankPoint >= 16 && DataController.Instance.rankPoint <= 21)
        {
            buddyPassIron.interactable = true;
            buddyPassBronze.interactable = true;
            if (DataController.Instance.language == 0)
            {
                rankText.text = "Bronze";
                rank.GetComponent<UnityEngine.UI.Image>().overrideSprite = Bronze;
            }
            if(DataController.Instance.language == 1)
            {
                rankText.text = "Bronz";
                rank.GetComponent<UnityEngine.UI.Image>().overrideSprite = Bronze;
            }
        }
        if (DataController.Instance.rankPoint >= 22 && DataController.Instance.rankPoint <= 27)
        {
            buddyPassIron.interactable = true;
            buddyPassBronze.interactable = true;
            buddyPassSilver.interactable = true;
            if (DataController.Instance.language == 0)
            {
                rankText.text = "Silver";
                rank.GetComponent<UnityEngine.UI.Image>().overrideSprite = Silver;
            }
            if(DataController.Instance.language == 1)
            {
                rankText.text = "Ezüst";
                rank.GetComponent<UnityEngine.UI.Image>().overrideSprite = Silver;
            }
        }
        if (DataController.Instance.rankPoint >= 28 && DataController.Instance.rankPoint <= 33)
        {
            buddyPassIron.interactable = true;
            buddyPassBronze.interactable = true;
            buddyPassSilver.interactable = true;
            buddyPassGold.interactable = true;
            if (DataController.Instance.language == 0)
            {
                rankText.text = "Gold";
                rank.GetComponent<UnityEngine.UI.Image>().overrideSprite = Gold;
            }
            if (DataController.Instance.language == 1)
            {
                rankText.text = "Arany";
                rank.GetComponent<UnityEngine.UI.Image>().overrideSprite = Gold;
            }
        }
        if (DataController.Instance.rankPoint >= 34 && DataController.Instance.rankPoint <= 39)
        {
            buddyPassIron.interactable = true;
            buddyPassBronze.interactable = true;
            buddyPassSilver.interactable = true;
            buddyPassGold.interactable = true;
            buddyPassPlatinum.interactable = true;
            if (DataController.Instance.language == 0)
            {
                rankText.text = "Platinum";
                rank.GetComponent<UnityEngine.UI.Image>().overrideSprite = Platinum;
            }
            if (DataController.Instance.language == 1)
            {
                rankText.text = "Platina";
                rank.GetComponent<UnityEngine.UI.Image>().overrideSprite = Platinum;
            }
        }
        if (DataController.Instance.rankPoint >= 40 && DataController.Instance.rankPoint <= 45)
        {
            buddyPassIron.interactable = true;
            buddyPassBronze.interactable = true;
            buddyPassSilver.interactable = true;
            buddyPassGold.interactable = true;
            buddyPassPlatinum.interactable = true;
            buddyPassDiamond.interactable = true;
            if (DataController.Instance.language == 0)
            {
                rankText.text = "Diamond";
                rank.GetComponent<UnityEngine.UI.Image>().overrideSprite = Diamond;
            }
            if (DataController.Instance.language == 1)
            {
                rankText.text = "Gyémánt";
                rank.GetComponent<UnityEngine.UI.Image>().overrideSprite = Diamond;
            }
        }
        if (DataController.Instance.rankPoint >= 46 && DataController.Instance.rankPoint <= 51)
        {
            buddyPassIron.interactable = true;
            buddyPassBronze.interactable = true;
            buddyPassSilver.interactable = true;
            buddyPassGold.interactable = true;
            buddyPassPlatinum.interactable = true;
            buddyPassDiamond.interactable = true;
            buddyPassMaster.interactable = true;
            if (DataController.Instance.language == 0)
            {
                rankText.text = "Master";
                rank.GetComponent<UnityEngine.UI.Image>().overrideSprite = Master;
            }
            if (DataController.Instance.language == 1)
            {
                rankText.text = "Mester";
                rank.GetComponent<UnityEngine.UI.Image>().overrideSprite = Master;
            }
        }
        if (DataController.Instance.rankPoint >= 52 && DataController.Instance.rankPoint <= 57)
        {
            buddyPassIron.interactable = true;
            buddyPassBronze.interactable = true;
            buddyPassSilver.interactable = true;
            buddyPassGold.interactable = true;
            buddyPassPlatinum.interactable = true;
            buddyPassDiamond.interactable = true;
            buddyPassMaster.interactable = true;
            buddyPassGrandmaster.interactable = true;
            if (DataController.Instance.language == 0)
            {
                rankText.text = "Grandmaster";
                rank.GetComponent<UnityEngine.UI.Image>().overrideSprite = Grandmaster;
            }
            if (DataController.Instance.language == 1)
            {
                rankText.text = "Nagymester";
                rank.GetComponent<UnityEngine.UI.Image>().overrideSprite = Grandmaster;
            }
        }
        if (DataController.Instance.rankPoint >= 58)
        {
            buddyPassIron.interactable = true;
            buddyPassBronze.interactable = true;
            buddyPassSilver.interactable = true;
            buddyPassGold.interactable = true;
            buddyPassPlatinum.interactable = true;
            buddyPassDiamond.interactable = true;
            buddyPassMaster.interactable = true;
            buddyPassGrandmaster.interactable = true;
            buddyPassChallenger.interactable = true;
            if (DataController.Instance.language == 0)
            {
                rankText.text = "Challenger";
                rank.GetComponent<UnityEngine.UI.Image>().overrideSprite = Challenger;
            }
            if (DataController.Instance.language == 1)
            {
                rankText.text = "Kihívó";
                rank.GetComponent<UnityEngine.UI.Image>().overrideSprite = Challenger;
            }
        }
    }

    public void BuddyPassIron()
    {
        DataController.Instance.buddypass = 1;
        DataController.Instance.Save();
    }
    public void BuddyPassBronze()
    {
        DataController.Instance.buddypass = 2;
        DataController.Instance.Save();
    }
    public void BuddyPassSilver()
    {
        DataController.Instance.buddypass = 3;
        DataController.Instance.Save();
    }
    public void BuddyPassGold()
    {
        DataController.Instance.buddypass = 4;
        DataController.Instance.Save();
    }
    public void BuddyPassPlatinum()
    {
        DataController.Instance.buddypass = 5;
        DataController.Instance.Save();
    }
    public void BuddyPassDiamond()
    {
        DataController.Instance.buddypass = 6;
        DataController.Instance.Save();
    }
    public void BuddyPassMaster()
    {
        DataController.Instance.buddypass = 7;
        DataController.Instance.Save();
    }
    public void BuddyPassGrandmaster()
    {
        DataController.Instance.buddypass = 8;
        DataController.Instance.Save();
    }
    public void BuddyPassChallenger()
    {
        DataController.Instance.buddypass = 9;
        DataController.Instance.Save();
    }

    public void buddyPassInteractable()
    {
        if(DataController.Instance.buddypass == 1)
        {
            buddyPassIron.interactable = true;
        }
        if (DataController.Instance.buddypass == 2)
        {
            buddyPassBronze.interactable = true;
        }
        if (DataController.Instance.buddypass == 3)
        {
            buddyPassSilver.interactable = true;
        }
        if (DataController.Instance.buddypass == 4)
        {
            buddyPassGold.interactable = true;
        }
        if (DataController.Instance.buddypass == 5)
        {
            buddyPassPlatinum.interactable = true;
        }
        if (DataController.Instance.buddypass == 6)
        {
            buddyPassDiamond.interactable = true;
        }
        if (DataController.Instance.buddypass == 7)
        {
            buddyPassMaster.interactable = true;
        }
        if (DataController.Instance.buddypass == 8)
        {
            buddyPassGrandmaster.interactable = true;
        }
        if (DataController.Instance.buddypass == 9)
        {
            buddyPassChallenger.interactable = true;
        }
    }
}
