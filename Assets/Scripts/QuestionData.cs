using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class QuestionData
{
    public string questionText;
    public string hint;
    public string category;
    public AnswerData[] answers;
}
