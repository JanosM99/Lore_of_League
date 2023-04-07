using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentSummonerSpell : MonoBehaviour
{
    public Sprite heal;
    public Sprite ignite;
    public Sprite ghost;
    public Sprite exhaust;
    public Sprite flash;
    public Sprite empty;

    public GameObject SummonerImage1;
    public GameObject SummonerImage2;

    void Start()
    {

    }
    void Update()
    {
        CurrentSummonerSpellScript();
    }

    void CurrentSummonerSpellScript()
    {

        // SUMMONERSPELL1

        if (DataController.Instance.summonerSpell1 == 1)
        {
        SummonerImage1.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = heal;
        }
        if (DataController.Instance.summonerSpell1 == 2)
        {
        SummonerImage1.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = ignite;
        }
        if (DataController.Instance.summonerSpell1 == 3)
        {
        SummonerImage1.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = ghost;
        }
        if (DataController.Instance.summonerSpell1 == 4)
        {
        SummonerImage1.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = flash;
        }
        if (DataController.Instance.summonerSpell1 == 5)
        {
        SummonerImage1.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = exhaust;
        }

        // SUMMONERSPELL 2
       

        if (DataController.Instance.summonerSpell2 == 1)
        {
        SummonerImage2.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = heal;
        }
        if (DataController.Instance.summonerSpell2 == 2)
        {
        SummonerImage2.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = ignite;
        }
        if (DataController.Instance.summonerSpell2 == 3)
        {
        SummonerImage2.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = ghost;
        }
        if (DataController.Instance.summonerSpell2 == 4)
        {
        SummonerImage2.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = flash;
        }
        if (DataController.Instance.summonerSpell2 == 5)
        {
        SummonerImage2.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = exhaust;
        }
    }
}

