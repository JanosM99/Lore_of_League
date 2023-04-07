using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuddySupportYou : MonoBehaviour
{

    public GameController gameControllerScript;

    public GameObject buddyImage1;
    public GameObject buddyImage2;
    public GameObject buddyImage3;
    public GameObject buddyImage4;
    public GameObject buddyImage5;
    public GameObject buddyImage6;
    public GameObject buddyImage7;

    public AudioClip BuddyShowUp;
    


    // Start is called before the first frame update
    void Start()
    {
        gameControllerScript = GameObject.Find("GameController").GetComponent<GameController>();
        ComeSupportBuddy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ComeSupportBuddy()
    {
        if(DataController.Instance.buddy == 0)
        {

        }
        if(DataController.Instance.buddy == 1)
        {
            StartCoroutine(Buddy1Spawner());
        }
        if (DataController.Instance.buddy == 2)
        {
            StartCoroutine(Buddy2Spawner());
        }
        if (DataController.Instance.buddy == 3)
        {
            StartCoroutine(Buddy3Spawner());
        }
        if (DataController.Instance.buddy == 4)
        {
            StartCoroutine(Buddy4Spawner());
        }
        if (DataController.Instance.buddy == 5)
        {
            StartCoroutine(Buddy5Spawner());
        }
        if (DataController.Instance.buddy == 6)
        {
            StartCoroutine(Buddy6Spawner());
        }
        if (DataController.Instance.buddy == 7)
        {
            StartCoroutine(Buddy7Spawner());
        }
    }

    // BUDDY 1 //

    public IEnumerator Buddy1Spawner()
    {
        yield return new WaitForSeconds(Mathf.Lerp(10.0f, 55.0f, Random.value));
        buddyImage1.SetActive(true);
        gameControllerScript.GameSound.PlayOneShot(BuddyShowUp, 1.0f);
        StartCoroutine(Buddy1SpawnEnd());
    }
    public IEnumerator Buddy1SpawnEnd()
    {
        yield return new WaitForSeconds(7);
        buddyImage1.SetActive(false);
    }


    // BUDDY 2 //

    public IEnumerator Buddy2Spawner()
    {
        yield return new WaitForSeconds(Mathf.Lerp(10.0f, 55.0f, Random.value));
        buddyImage2.SetActive(true);
        gameControllerScript.GameSound.PlayOneShot(BuddyShowUp, 1.0f);
        StartCoroutine(Buddy2SpawnEnd());
    }
    public IEnumerator Buddy2SpawnEnd()
    {
        yield return new WaitForSeconds(7);
        buddyImage2.SetActive(false);
    }

    // BUDDY 3 //

    public IEnumerator Buddy3Spawner()
    {
        yield return new WaitForSeconds(Mathf.Lerp(10.0f, 55.0f, Random.value));
        buddyImage3.SetActive(true);
        gameControllerScript.GameSound.PlayOneShot(BuddyShowUp, 1.0f);
        StartCoroutine(Buddy3SpawnEnd());
    }
    public IEnumerator Buddy3SpawnEnd()
    {
        yield return new WaitForSeconds(7);
        buddyImage3.SetActive(false);
    }

    // BUDDY 4 //
    public IEnumerator Buddy4Spawner()
    {
        yield return new WaitForSeconds(Mathf.Lerp(10.0f, 55.0f, Random.value));
        buddyImage4.SetActive(true);
        gameControllerScript.GameSound.PlayOneShot(BuddyShowUp, 1.0f);
        StartCoroutine(Buddy4SpawnEnd());
    }
    public IEnumerator Buddy4SpawnEnd()
    {
        yield return new WaitForSeconds(7);
        buddyImage4.SetActive(false);
    }

    // BUDDY 5 //
    public IEnumerator Buddy5Spawner()
    {
        yield return new WaitForSeconds(Mathf.Lerp(10.0f, 55.0f, Random.value));
        buddyImage5.SetActive(true);
        gameControllerScript.GameSound.PlayOneShot(BuddyShowUp, 1.0f);
        StartCoroutine(Buddy5SpawnEnd());
    }
    public IEnumerator Buddy5SpawnEnd()
    {
        yield return new WaitForSeconds(7);
        buddyImage5.SetActive(false);
    }


    // BUDDY 6 //
    public IEnumerator Buddy6Spawner()
    {
        yield return new WaitForSeconds(Mathf.Lerp(10.0f, 55.0f, Random.value));
        buddyImage6.SetActive(true);
        gameControllerScript.GameSound.PlayOneShot(BuddyShowUp, 1.0f);
        StartCoroutine(Buddy6SpawnEnd());
    }
    public IEnumerator Buddy6SpawnEnd()
    {
        yield return new WaitForSeconds(7);
        buddyImage6.SetActive(false);
    }

    // BUDDY 7 //
    public IEnumerator Buddy7Spawner()
    {
        yield return new WaitForSeconds(Mathf.Lerp(10.0f, 55.0f, Random.value));
        buddyImage7.SetActive(true);
        gameControllerScript.GameSound.PlayOneShot(BuddyShowUp, 1.0f);
        StartCoroutine(Buddy7SpawnEnd());
    }
    public IEnumerator Buddy7SpawnEnd()
    {
        yield return new WaitForSeconds(7);
        buddyImage7.SetActive(false);
    }


}
