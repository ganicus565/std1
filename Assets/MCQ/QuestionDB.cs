using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class QuestionDB : MonoBehaviour
{
    [SerializeField]
    public Question[] questions;
    public TMP_Text  questionLvl;

    [SerializeField]
    public Text[] optLvl;
   
    public Toggle A;
    public Toggle B;
    public Toggle C;
    public Toggle D;
    int currQus =0;
    private void Start()
    {
        SetNewQuestion(0);
    }
    public void OnAnswerSelected()
    {
        if(D.isOn==true)
        {
            Debug.Log("correct");
        }
        else
        {
            Debug.Log("Wrong");

        }
    }

    public void SetNewQuestion(int qNo)
    {
        questionLvl.text = questions[qNo].question;
        for (int i = 0; i < questions[qNo].opts.Length; i++)
        {
            optLvl[i].text = questions[qNo].opts[i];
        }

    }
    public void NextQst()
    {
        if (currQus >= questions.Length)
            return;
        currQus++;
        SetNewQuestion(currQus);
    }
    public void PvsQst()
    {
        if (currQus == 0)
            return;
        currQus--;
        SetNewQuestion(currQus);
    }
}

[System.Serializable]
public class Question
{
    public string question;
    public string[] opts;
    public int ans;

}
