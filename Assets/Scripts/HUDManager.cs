using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public Text scoreTxt;
    int score=100;
    public void OnClickPlayBtn()
    {
        score++;
        scoreTxt.text = score.ToString();
        Debug.Log("Starting game");
    }

}
