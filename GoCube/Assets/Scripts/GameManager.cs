using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject levelWonUI;
    public PlayerMovement coins;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject coinsCounter;
    public Button nxtLvlBtn;
    public Text nxtLvlTxt;
    private Color32 emptyStar = new Color32(255, 255, 255, 100);
    private Color32 fullStar = new Color32(245, 255, 78, 100);

    public List<Image> lvl1 = new List<Image>();
    public List<Image> lvl2 = new List<Image>();
    public List<Image> lvl3 = new List<Image>();
    public List<Image> lvl4 = new List<Image>();
    public List<Image> lvl5 = new List<Image>();
    public List<Image> lvl6 = new List<Image>();

    public static int level1Stars;
    public static int level2Stars;
    public static int level3Stars;
    public static int level4Stars;
    public static int level5Stars;
    public static int level6Stars;

    public static bool replay;

    void Start()
    {
        if (SceneManager.GetActiveScene().name == "EndScreen")
        {
            for (int i = 0; i < level1Stars; i++)
            {
                lvl1[i].color = fullStar;
            }
            for (int i = 0; i < level2Stars; i++)
            {
                lvl2[i].color = fullStar;
            }
            for (int i = 0; i < level3Stars; i++)
            {
                lvl3[i].color = fullStar;
            }
            for (int i = 0; i < level4Stars; i++)
            {
                lvl4[i].color = fullStar;
            }
            for (int i = 0; i < level5Stars; i++)
            {
                lvl5[i].color = fullStar;
            }
            for (int i = 0; i < level6Stars; i++)
            {
                lvl6[i].color = fullStar;
            }
        }
    }

    public void CompleteLevel()
    {
        coinsCounter.SetActive(false);
        levelWonUI.SetActive(true);
        if (replay)
        {
            nxtLvlTxt.text = "End Screen";
            nxtLvlBtn.onClick.RemoveAllListeners();
            nxtLvlBtn.onClick.AddListener(LoadEndScreen);            
        }
        if ((SceneManager.GetActiveScene().name == "Level01"))
        {
            if (coins.coinsCount == 0)
            {
                star1.GetComponent<Image>().color = emptyStar;
                star2.GetComponent<Image>().color = emptyStar;
                star3.GetComponent<Image>().color = emptyStar;
                nxtLvlBtn.interactable = false;
            }            
            if (coins.coinsCount == 1)
            {
                star1.GetComponent<Image>().color = fullStar;
                star2.GetComponent<Image>().color = fullStar;
                star3.GetComponent<Image>().color = fullStar;
                level1Stars = 3;
            }
        }
        if ((SceneManager.GetActiveScene().name == "Level02"))
        {
            if (coins.coinsCount == 0)
            {
                star1.GetComponent<Image>().color = emptyStar;
                star2.GetComponent<Image>().color = emptyStar;
                star3.GetComponent<Image>().color = emptyStar;
                nxtLvlBtn.interactable = false;
            }
            if (coins.coinsCount == 1)
            {
                star1.GetComponent<Image>().color = fullStar;
                star2.GetComponent<Image>().color = fullStar;
                star3.GetComponent<Image>().color = emptyStar;
                level2Stars = 2;
            }
            if (coins.coinsCount == 2)
            {
                star1.GetComponent<Image>().color = fullStar;
                star2.GetComponent<Image>().color = fullStar;
                star3.GetComponent<Image>().color = fullStar;
                level2Stars = 3;
            }
        }
        if ((SceneManager.GetActiveScene().name == "Level03"))
        {
            if (coins.coinsCount == 0)
            {
                star1.GetComponent<Image>().color = emptyStar;
                star2.GetComponent<Image>().color = emptyStar;
                star3.GetComponent<Image>().color = emptyStar;
                nxtLvlBtn.interactable = false;
            }
            if (coins.coinsCount == 1)
            {
                star1.GetComponent<Image>().color = fullStar;
                star2.GetComponent<Image>().color = emptyStar;
                star3.GetComponent<Image>().color = emptyStar;
                level3Stars = 1;
            }
            if (coins.coinsCount == 2)
            {
                star1.GetComponent<Image>().color = fullStar;
                star2.GetComponent<Image>().color = fullStar;
                star3.GetComponent<Image>().color = emptyStar;
                level3Stars = 2;
            }
            if (coins.coinsCount == 3)
            {
                star1.GetComponent<Image>().color = fullStar;
                star2.GetComponent<Image>().color = fullStar;
                star3.GetComponent<Image>().color = fullStar;
                level3Stars = 3;
            }
        }
        if ((SceneManager.GetActiveScene().name == "Level04"))
        {
            if (coins.coinsCount == 0)
            {
                star1.GetComponent<Image>().color = emptyStar;
                star2.GetComponent<Image>().color = emptyStar;
                star3.GetComponent<Image>().color = emptyStar;
                nxtLvlBtn.interactable = false;
            }
            if (coins.coinsCount == 1)
            {                
                star1.GetComponent<Image>().color = fullStar;
                star2.GetComponent<Image>().color = emptyStar;
                star3.GetComponent<Image>().color = emptyStar;
                level4Stars = 1;
            }
            if (coins.coinsCount == 2)
            {
                star1.GetComponent<Image>().color = fullStar;
                star2.GetComponent<Image>().color = fullStar;
                star3.GetComponent<Image>().color = emptyStar;
                level4Stars = 2;
            }
            if (coins.coinsCount == 3)
            {
                star1.GetComponent<Image>().color = fullStar;
                star2.GetComponent<Image>().color = fullStar;
                star3.GetComponent<Image>().color = fullStar;
                level4Stars = 3;
            }
        }
        if ((SceneManager.GetActiveScene().name == "Level05"))
        {
            if (coins.coinsCount == 0)
            {
                star1.GetComponent<Image>().color = emptyStar;
                star2.GetComponent<Image>().color = emptyStar;
                star3.GetComponent<Image>().color = emptyStar;
                nxtLvlBtn.interactable = false;
            }
            if (coins.coinsCount == 1)
            {
                star1.GetComponent<Image>().color = fullStar;
                star2.GetComponent<Image>().color = emptyStar;
                star3.GetComponent<Image>().color = emptyStar;
                level5Stars = 1;
            }
            if (coins.coinsCount == 2 || coins.coinsCount == 3)
            {
                star1.GetComponent<Image>().color = fullStar;
                star2.GetComponent<Image>().color = fullStar;
                star3.GetComponent<Image>().color = emptyStar;
                level5Stars = 2;
            }
            if (coins.coinsCount == 4)
            {
                star1.GetComponent<Image>().color = fullStar;
                star2.GetComponent<Image>().color = fullStar;
                star3.GetComponent<Image>().color = fullStar;
                level5Stars = 3;
            }
        }
        if ((SceneManager.GetActiveScene().name == "Level06"))
        {
            if (coins.coinsCount == 0)
            {
                star1.GetComponent<Image>().color = emptyStar;
                star2.GetComponent<Image>().color = emptyStar;
                star3.GetComponent<Image>().color = emptyStar;
                nxtLvlBtn.interactable = false;
            }
            if (coins.coinsCount == 1 || coins.coinsCount == 2)
            {
                star1.GetComponent<Image>().color = fullStar;
                star2.GetComponent<Image>().color = emptyStar;
                star3.GetComponent<Image>().color = emptyStar;
                level6Stars = 1;
            }
            if (coins.coinsCount == 3 || coins.coinsCount == 4)
            {
                star1.GetComponent<Image>().color = fullStar;
                star2.GetComponent<Image>().color = fullStar;
                star3.GetComponent<Image>().color = emptyStar;
                level6Stars = 2;
            }
            if (coins.coinsCount == 5)
            {
                star1.GetComponent<Image>().color = fullStar;
                star2.GetComponent<Image>().color = fullStar;
                star3.GetComponent<Image>().color = fullStar;
                level6Stars = 3;
            }
        }
    }

    public IEnumerator RestartLevel()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    } 

    public void LoadEndScreen()
    {
        SceneManager.LoadScene("EndScreen");
    }

    public void Level1Replay()
    {
        replay = true;
        SceneManager.LoadScene("Level01");
    }

    public void Level2Replay()
    {
        replay = true;
        SceneManager.LoadScene("Level02");
    }

    public void Level3Replay()
    {
        replay = true;
        SceneManager.LoadScene("Level03");
    }

    public void Level4Replay()
    {
        replay = true;
        SceneManager.LoadScene("Level04");
    }

    public void Level5Replay()
    {
        replay = true;
        SceneManager.LoadScene("Level05");
    }

    public void Level6Replay()
    {
        replay = true;
        SceneManager.LoadScene("Level06");
    }
}
