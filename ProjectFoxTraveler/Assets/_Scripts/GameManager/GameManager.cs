using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject Credits;
    public GameObject[] TextAndButtons;
    public Animator animatorControl;


    public void LoadSceneGamePlay()
    {
        SceneManager.LoadScene("Gameplay", LoadSceneMode.Single);
    }

    public void UseCredits()
    {
        Credits.gameObject.SetActive(true);
        for (int counting = 0; counting <= TextAndButtons.Length; counting++)
        {
            TextAndButtons[counting].SetActive(true);
        }
    }

    public void ReturnButton()
    {
        animatorControl.SetBool("OutTransition", true);
        StartCoroutine(ShowButtonsAndText());
        for (int counting = 0; counting <= TextAndButtons.Length; counting++)
        {
            TextAndButtons[counting].SetActive(false);
        }
    }

    IEnumerator ShowButtonsAndText()
    {
        yield return new WaitForSeconds(1.5f);
        Credits.gameObject.SetActive(false);
    }
}
