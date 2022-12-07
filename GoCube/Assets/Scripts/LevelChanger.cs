using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{

    private int levelToLoad;
    public Animator animator;

    public void FadeToNextLevel()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    IEnumerator FadeSameLevel(int levelIndex)
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(levelToLoad);
    }

    public void OnFadeComplete()
    {      
        StartCoroutine(FadeSameLevel(levelToLoad));
    }

    public void FadeRestart()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex);
    }
}
