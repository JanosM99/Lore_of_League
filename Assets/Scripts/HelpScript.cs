using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpScript : MonoBehaviour
{

    public static HelpScript instance;

    public static HelpScript Instance { get { return instance; } }

    public GameObject notEnoughText;
    public GameObject notEnoughText2;
    public Button buyhelpButton;
    public Button helpButton;
    public GameObject helpPanel;
    public GameObject hintPanel;

    public GameObject englishNotEnough;
    public GameObject hungarianNotEnough;
    public void Start()
    {
        helpButton.onClick.AddListener(OnClickHelpButton);
        buyhelpButton.onClick.AddListener(buyHelpForCurrency);
    }
    public void Update()
    {
        if (helpPanel.activeSelf)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    public void OnClickHelpButton()
    {
        helpPanel.SetActive(true);
        
        
    }
    public void HintPanel()
    {
     hintPanel.SetActive(true);
     helpPanel.SetActive(false);
    }
    

    public void buyHelpForCurrency()
    {
        if(DataController.Instance.currency < 25)
        {
            if(DataController.Instance.language == 0)
            {
                notEnoughText.SetActive(true);
                notEnoughText2.SetActive(true);
                englishNotEnough.SetActive(true);
            }
            if(DataController.Instance.language == 1)
            {
                notEnoughText.SetActive(true);
                notEnoughText2.SetActive(true);
                hungarianNotEnough.SetActive(true);

            }

        }
        else
        {
            DataController.Instance.currency -= 25;
            DataController.Instance.Save();
            HintPanel();
        }
    }

}
