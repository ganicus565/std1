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
   
    public Toggle[] AnsRedio;

    int currQus =0;
    private void Start()
    {
        SetNewQuestion(0);
    }
    public void OnAnswerSelected(int optNo)
    {
        Debug.Log("Selected  Ans " + optNo);
        if (AnsRedio[optNo].isOn== true)
            questions[currQus].sectAns = optNo;
    }

    public void SetNewQuestion(int qNo)
    {
        questionLvl.text = questions[qNo].question;
        for (int i = 0; i < questions[qNo].opts.Length; i++)
        {
            optLvl[i].text = questions[qNo].opts[i];
            if (i == questions[qNo].sectAns)
                AnsRedio[i].isOn = true;
            else
                AnsRedio[i].isOn = false;

        }

    }
    public void NextQst()
    {
        if (currQus >= questions.Length-1)
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
    public int sectAns;

}
