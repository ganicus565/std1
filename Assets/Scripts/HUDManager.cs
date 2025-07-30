using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public GameObject Startpanel;
    int score=100;
    public void OnClickPlayBtn()
    {
        Startpanel.SetActive(false);
     //   score++;
     //   scoreTxt.text = score.ToString();
        Debug.Log("Starting game");
    }

}
