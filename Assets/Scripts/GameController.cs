using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int randomBuddyText;
    public Sprite[] buddyTextes;
    public Image buddy1ImageBubble;
    public Image buddy2ImageBubble;
    public Image buddy3ImageBubble;
    public Image buddy4ImageBubble;
    public Image buddy5ImageBubble;
    public Image buddy6ImageBubble;
    public Image buddy7ImageBubble;

    public AudioSource GameSound;
    public AudioClip scoredPoint;
    public AudioClip EnemyScoredPoint;
    public AudioClip DragonRoar;
    public AudioClip scoredPointHun;
    public AudioClip scoredEnemyPointHun;
    public GameObject TimesUpEng;
    public GameObject TimesUpHun;

    
    public Text currency;
    public Text whereYouFromText;
    public Text hintText;
    public Text questionText;
    public GameObject questionPanel;
    public GameObject roundEndPanel;
    public Text timeRemainingDisplayText;
    public SimpleObjectPool answerButtonObjectPool;
    public Transform answerButtonParent;
    private DataController dataController;
    private RoundData currentRoundData;
    private QuestionData[] questionPool;

    public bool isRoundActive;
    public float timeRemaining;
    private int questionIndex;
    public bool isExhaustActive;

    public BuddySupportYou buddySupportYouScript;
    private List<GameObject> answerButtonGameObjects = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        dataController = FindObjectOfType<DataController>();
        currentRoundData = dataController.GetCurrentRoundData();
        questionPool = currentRoundData.questions;
        timeRemaining = currentRoundData.timeLimitInSecond;
        currency.text = DataController.Instance.currency.ToString();
        GameSound = GetComponent<AudioSource>();
        UpdateTimeRemainingDisplay();

        questionIndex = 0;

        ShowQuestion();
        isRoundActive = true;
        isExhaustActive = false;
        buddySupportYouScript = GameObject.Find("GameController").GetComponent<BuddySupportYou>();
    }
   
    public void ShowQuestion()
    {
        RemoveAnswerButtons();
        QuestionData questionData = questionPool[UnityEngine.Random.Range(0, currentRoundData.questions.Length)];
        questionText.text = questionData.questionText;
        whereYouFromText.text = questionData.category;
        hintText.text = questionData.hint;

        for(int i = 0;i< questionData.answers.Length;i++)
        {
            GameObject answerButtonGameObject = answerButtonObjectPool.GetObject();
            answerButtonGameObject.transform.SetParent(answerButtonParent, false);
            answerButtonGameObjects.Add(answerButtonGameObject);
            AnswerButtonScript answerButton = answerButtonGameObject.GetComponent<AnswerButtonScript>();
            answerButton.Setup(questionData.answers[i]);
        }
    }
    public void RemoveAnswerButtons()
    {
        while(answerButtonGameObjects.Count > 0)
        {
            answerButtonObjectPool.ReturnObject(answerButtonGameObjects[0]);
            answerButtonGameObjects.RemoveAt(0);
        }
    }

    public void AnswerButtonClicked(bool isCorrect)
    {
        if (isCorrect)
        {
            DataController.Instance.rankPoint++;
            DataController.Instance.currency++;
            timeRemaining += 5.0f;
            if(DataController.Instance.language == 0)
            {
                GameSound.PlayOneShot(scoredPoint, 1.0f);
            }
            if(DataController.Instance.language == 1)
            {
                GameSound.PlayOneShot(scoredPointHun, 1.0f);
            }
            if (DataController.Instance.rankPoint < 0)
            {
                DataController.Instance.rankPoint = 0;
            }
            if (DataController.Instance.currency < 0)
            {
                DataController.Instance.currency = 0;
            }
            currency.text = DataController.Instance.currency.ToString();
            DataController.Instance.Save();
        }
        else
        {
            DataController.Instance.rankPoint--;
            DataController.Instance.currency--;
            timeRemaining -= 10.0f;
            if (DataController.Instance.language == 0)
            {
                GameSound.PlayOneShot(EnemyScoredPoint, 1.0f);
            }
            if (DataController.Instance.language == 1)
            {
                GameSound.PlayOneShot(scoredEnemyPointHun, 1.0f);
            }
            if (DataController.Instance.rankPoint < 0)
            {
                DataController.Instance.rankPoint = 0;
            }
            if (DataController.Instance.currency < 0)
            {
                DataController.Instance.currency = 0;
            }
            currency.text = DataController.Instance.currency.ToString();
            DataController.Instance.Save();
        }
        if(questionPool.Length >questionIndex + 1)
        {
            questionIndex++;
            ShowQuestion();
        }
        else
        {
            EndRound();
        }
    }
    public void EndRound()
    {
        isRoundActive = false;
        questionPanel.SetActive(false);
        roundEndPanel.SetActive(true);
        GameSound.PlayOneShot(DragonRoar, 1.0f);
        if(DataController.Instance.language == 0)
        {
            TimesUpEng.SetActive(true);
        }
        if(DataController.Instance.language == 1)
        {
            TimesUpHun.SetActive(true);
        }
        if(DataController.Instance.buddy == 1)
        {
            buddySupportYouScript.buddyImage1.SetActive(true);
            buddy1ImageBubble.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = buddyTextes[randomBuddyText];
            buddy1ImageBubble.gameObject.SetActive(true);
        }
        if (DataController.Instance.buddy == 2)
        {
            buddySupportYouScript.buddyImage2.SetActive(true);
            buddy2ImageBubble.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = buddyTextes[randomBuddyText];
            buddy2ImageBubble.gameObject.SetActive(true);
            
        }
        if (DataController.Instance.buddy == 3)
        {
            buddySupportYouScript.buddyImage3.SetActive(true);
            buddy3ImageBubble.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = buddyTextes[randomBuddyText];
            buddy3ImageBubble.gameObject.SetActive(true);
        }
        if (DataController.Instance.buddy == 4)
        {
            buddySupportYouScript.buddyImage4.SetActive(true);
            buddy4ImageBubble.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = buddyTextes[randomBuddyText];
            buddy4ImageBubble.gameObject.SetActive(true);
        }
        if (DataController.Instance.buddy == 5)
        {
            buddySupportYouScript.buddyImage5.SetActive(true);
            buddy5ImageBubble.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = buddyTextes[randomBuddyText];
            buddy5ImageBubble.gameObject.SetActive(true);
        }
        if (DataController.Instance.buddy == 6)
        {
            buddySupportYouScript.buddyImage6.SetActive(true);
            buddy6ImageBubble.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = buddyTextes[randomBuddyText];
            buddy6ImageBubble.gameObject.SetActive(true);
        }
        if (DataController.Instance.buddy == 7)
        {
            buddySupportYouScript.buddyImage7.SetActive(true);
            buddy7ImageBubble.gameObject.GetComponent<UnityEngine.UI.Image>().overrideSprite = buddyTextes[randomBuddyText];
            buddy7ImageBubble.gameObject.SetActive(true);
        }
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MenuScreen");
    }

    public void UpdateTimeRemainingDisplay()
    {
        timeRemainingDisplayText.text = Mathf.Round(timeRemaining).ToString();
    }

    public void ChangeRandomValue()
    {
        if (DataController.Instance.buddypass == 0)
        {
            randomBuddyText = UnityEngine.Random.Range(0, 4);
        }
        if (DataController.Instance.buddypass == 1)
        {
            randomBuddyText = UnityEngine.Random.Range(0, 5);
        }
        if (DataController.Instance.buddypass == 2)
        {
            randomBuddyText = UnityEngine.Random.Range(0, 6);
        }
        if (DataController.Instance.buddypass == 3)
        {
            randomBuddyText = UnityEngine.Random.Range(0, 7);
        }
        if (DataController.Instance.buddypass == 4)
        {
            randomBuddyText = UnityEngine.Random.Range(0, 8);
        }
        if (DataController.Instance.buddypass == 5)
        {
            randomBuddyText = UnityEngine.Random.Range(0, 9);
        }
        if (DataController.Instance.buddypass == 6)
        {
            randomBuddyText = UnityEngine.Random.Range(0, 10);
        }
        if (DataController.Instance.buddypass == 7)
        {
            randomBuddyText = UnityEngine.Random.Range(0, 11);
        }
        if (DataController.Instance.buddypass == 8)
        {
            randomBuddyText = UnityEngine.Random.Range(0, 12);
        }
        if (DataController.Instance.buddypass == 9)
        {
            randomBuddyText = UnityEngine.Random.Range(0, 13);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (isRoundActive)
        {
            if(isExhaustActive == false)
            {
                timeRemaining -= Time.deltaTime;
                UpdateTimeRemainingDisplay();
            }
            else
            {
                timeRemaining -= Time.deltaTime / 3;
                UpdateTimeRemainingDisplay();
            }
            if(timeRemaining <= 0f)
            {
                EndRound();
            }
        }
        ChangeRandomValue();

    }
}
