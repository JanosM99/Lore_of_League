using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataController : MonoBehaviour
{
    private static DataController instance;
    public RoundData[] allRoundData;

    public static DataController Instance { get { return instance; } }

    public int rankPoint = 0;
    public int currency = 0;
    public int language = 0;
    public int summonerSpell1 = 0;
    public int summonerSpell2 = 0;
    public int buddy = 0;
    public int buddypass = 0;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("MenuScreen");
    }
    public void Awake()
    {
        instance = this;
        if (PlayerPrefs.HasKey("rankPoint"))
        {
            rankPoint = PlayerPrefs.GetInt("rankPoint");
            currency = PlayerPrefs.GetInt("currency");
            language = PlayerPrefs.GetInt("language");
            summonerSpell1 = PlayerPrefs.GetInt("summonerSpell1");
            summonerSpell2 = PlayerPrefs.GetInt("summonerSpell2");
            buddy = PlayerPrefs.GetInt("buddy");
            buddypass = PlayerPrefs.GetInt("buddypass");
        }
        else
        {
            Save();
        }
        if (rankPoint < 0)
        {
            rankPoint = 0;
        }
        if (currency < 0)
        {
            currency = 0;
        }
    }
    public RoundData GetCurrentRoundData()
    {
        if(language == 0)
        {
            return allRoundData[0];
        }
        else
        {
            return allRoundData[1];
        }

    }
    public void Save()
    {
        PlayerPrefs.SetInt("rankPoint", rankPoint);
        PlayerPrefs.SetInt("currency", currency);
        PlayerPrefs.SetInt("language", language);
        PlayerPrefs.SetInt("summonerSpell1", summonerSpell1);
        PlayerPrefs.SetInt("summonerSpell2", summonerSpell2);
        PlayerPrefs.SetInt("buddy", buddy);
        PlayerPrefs.SetInt("buddypass", buddypass);
    }

}
