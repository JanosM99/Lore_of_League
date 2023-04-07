using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellButtons : MonoBehaviour
{
    public Sprite heal;
    public Sprite ignite;
    public Sprite ghost;
    public Sprite exhaust;
    public Sprite flash;
    public Sprite empty;
    public Sprite empty2;

    public Button SummonerButton1;
    public Button SummonerButton2;

    public GameController gameControllerScript;

    public bool summonerButton1isActive;
    public bool summonerButton2isActive;

    public AudioClip exhaustSound;
    public AudioClip flashSound;
    public AudioClip ghostSound;
    public AudioClip healSound;
    public AudioClip igniteSound;



    // Start is called before the first frame update
    void Start()
    {
    gameControllerScript = GameObject.Find("GameController").GetComponent<GameController>();
        
        
        summonerButton2isActive = true;
        summonerButton1isActive = true;


    }

    // Update is called once per frame
    void Update()
    {
        SummonerSpellButtonScript();
    }

    public void SummonerSpellButtonScript()
    {

        if (DataController.Instance.summonerSpell1 == 1)
        {
            SummonerButton1.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = heal;
        }
        if (DataController.Instance.summonerSpell1 == 2)
        {
            SummonerButton1.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = ignite;
        }
        if (DataController.Instance.summonerSpell1 == 3)
        {
            SummonerButton1.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = ghost;
        }
        if (DataController.Instance.summonerSpell1 == 4)
        {
            SummonerButton1.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = flash;
        }
        if (DataController.Instance.summonerSpell1 == 5)
        {
            SummonerButton1.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = exhaust;
        }
        if (summonerButton1isActive == false)
        {
            SummonerButton1.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = empty;
        }

        // SUMMONERSPELL 2


        if (DataController.Instance.summonerSpell2 == 1)
        {
            SummonerButton2.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = heal;
        }
        if (DataController.Instance.summonerSpell2 == 2)
        {
            SummonerButton2.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = ignite;
        }
        if (DataController.Instance.summonerSpell2 == 3)
        {
            SummonerButton2.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = ghost;
        }
        if (DataController.Instance.summonerSpell2 == 4)
        {
            SummonerButton2.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = flash;
        }
        if (DataController.Instance.summonerSpell2 == 5)
        {
            SummonerButton2.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = exhaust;
        }
        if (summonerButton2isActive == false)
        {
            SummonerButton2.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = empty2;
        }

    }

    public void FirstButtonSpellsOnClick()
    {
        if (DataController.Instance.summonerSpell1 == 1 && summonerButton1isActive)
        {
            healSpell();
            summonerButton1isActive = false;
            gameControllerScript.GameSound.PlayOneShot(healSound, 1.0f);
        }
        if (DataController.Instance.summonerSpell1 == 2 && summonerButton1isActive)
        {
            igniteSpell();
            summonerButton1isActive = false;
            gameControllerScript.GameSound.PlayOneShot(igniteSound, 1.0f);
        }
        if (DataController.Instance.summonerSpell1 == 3 && summonerButton1isActive)
        {
            ghostSpell();
            summonerButton1isActive = false;
            gameControllerScript.GameSound.PlayOneShot(ghostSound, 1.0f);
        }
        if (DataController.Instance.summonerSpell1 == 4 && summonerButton1isActive)
        {
            flashSpelll();
            summonerButton1isActive = false;
            gameControllerScript.GameSound.PlayOneShot(flashSound, 1.0f);
        }
        if (DataController.Instance.summonerSpell1 == 5 && summonerButton1isActive)
        {
            exhaustSpell();
            summonerButton1isActive = false;
            gameControllerScript.GameSound.PlayOneShot(exhaustSound, 1.0f);
        }
    }

    public void SecondButtonSpellsOnCLick()
    {
        if (DataController.Instance.summonerSpell2 == 1 && summonerButton2isActive)
        {
            healSpell();
            summonerButton2isActive = false;
            gameControllerScript.GameSound.PlayOneShot(healSound, 1.0f);
        }
        if (DataController.Instance.summonerSpell2 == 2 && summonerButton2isActive)
        {
            igniteSpell();
            summonerButton2isActive = false;
            gameControllerScript.GameSound.PlayOneShot(igniteSound, 1.0f);
        }
        if (DataController.Instance.summonerSpell2 == 3 && summonerButton2isActive)
        {
            ghostSpell();
            summonerButton2isActive = false;
            gameControllerScript.GameSound.PlayOneShot(ghostSound, 1.0f);
        }
        if (DataController.Instance.summonerSpell2 == 4 && summonerButton2isActive)
        {
            flashSpelll();
            summonerButton2isActive = false;
            gameControllerScript.GameSound.PlayOneShot(flashSound, 1.0f);
        }
        if (DataController.Instance.summonerSpell2 == 5 && summonerButton2isActive)
        {
            exhaustSpell();
            summonerButton2isActive = false;
            gameControllerScript.GameSound.PlayOneShot(exhaustSound, 1.0f);
        }
    }

    public void flashSpelll()
    {
        gameControllerScript.ShowQuestion();
    }
    public void healSpell()
    {
        gameControllerScript.timeRemaining += 10.0f;
    }
    public void igniteSpell()
    {
        gameControllerScript.ShowQuestion();
    }
    public void ghostSpell()
    {
        gameControllerScript.isRoundActive = false;
        StartCoroutine(GhostSpellActive());
    }
    public void exhaustSpell()
    {
        gameControllerScript.isExhaustActive = true;
        StartCoroutine(ExhaustSpellActive());
    }
    IEnumerator GhostSpellActive()
    {
        yield return new WaitForSeconds(10);
        gameControllerScript.isRoundActive = true;
    }

    IEnumerator ExhaustSpellActive()
    {
        yield return new WaitForSeconds(10);
        gameControllerScript.isExhaustActive = false;
    }

}
