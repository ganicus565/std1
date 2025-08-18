using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public GameObject Startpanel;
    
    public void OnClickPlayBtn()
    {
        Startpanel.SetActive(false);
    
        Debug.Log("Starting game");
       
    }
    public void OnReplay()
    {
        SceneManager.LoadScene("Tic", LoadSceneMode.Single);
    }

}
