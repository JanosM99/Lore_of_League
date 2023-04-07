using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public AudioSource MenuSource;
    public Text currencyText;
    public AudioClip SummonerQuitSound; 
    public AudioClip SummonerQuitHunSound;
    // Start is called before the first frame update
    void Start()
    {
        currencyText.text = " " + DataController.Instance.currency.ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void QuitGame()
    {
        if(DataController.Instance.language == 0)
        {
            MenuSource.PlayOneShot(SummonerQuitSound, 1.0f);
            StartCoroutine(SummonerQuitTime());
        }
        if(DataController.Instance.language == 1)
        {
            MenuSource.PlayOneShot(SummonerQuitHunSound, 1.0f);
            StartCoroutine(SummonerQuitTime());
        }


    }


    public void OnClickRate()
    {
        Application.OpenURL("market://details?id=com.ThePinkElephant.MazeRoll");
    }

    public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;
    }


    public IEnumerator SummonerQuitTime()
    {
        yield return new WaitForSeconds(3);
        Application.Quit();
    }

}
