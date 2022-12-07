using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndManager : MonoBehaviour
{

    public GameManager gameManager;
    private Color32 emptyStar = new Color32(255, 255, 255, 100);
    private Color32 fullStar = new Color32(245, 255, 78, 100);

    void Start()
    {
        //if (gameManager.level)
        //{

        //}
    }


    public void ExitGame()
    {
        Application.Quit();
    }
}
