using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Image[] btnImg;
    public Sprite cross;
    public Sprite zero;
    public int turn = 1;
    int clickCount = 0;
    public int[] array = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    int win = 0;
    public GameObject over;

    void Start()
    {
        Debug.Log(array.Length);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnSelected(int loc)
    {
        if (array[loc] == 0)
        {
            clickCount++;

            if (clickCount % 2 == 0)
                turn = 1;
            else
                turn = 2;
            array[loc] = turn;
            Debug.Log("On selected " + loc);


            if (turn == 1)
                btnImg[loc].sprite = cross;
            if (turn == 2)
                btnImg[loc].sprite = zero;
            CheckWinningCon();
        }


    }

    void CheckWinningCon()
    {

        if (array[0] == 1 && array[1] == 1 && array[2] == 1)
        {
            win = 1;
        }

        if (array[0] == 2 && array[1] == 2 && array[2] == 2)
        {
            win = 2;
        }

        Debug.Log("won " + win);
        if (win == 1 || win == 2)
            over.SetActive(true);
    }
}
