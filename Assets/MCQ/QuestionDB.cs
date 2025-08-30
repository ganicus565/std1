using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestionDB : MonoBehaviour
{
    public Toggle A;
    public Toggle B;
    public Toggle C;
    public Toggle D;

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
}
