using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject Credits;
    public GameObject Settings;
    public GameObject[] TextAndButtonsCredits;
    public GameObject[] TextAndButtonsSettings;

    public Animator animatorControlSettings;
    public Animator animatorControlCredits;
    public bool isCredits;
    public bool isSettings;

    public void LoadSceneGamePlay()
    {
        SceneManager.LoadScene("Gameplay", LoadSceneMode.Additive);
    }

    public void UseCredits()
    {
        isSettings = false;
        isCredits = true;
        Credits.gameObject.SetActive(true);
        ActivateUIObjects(isCredits, isSettings);
    }

    public void UseSettings()
    {
        isSettings = true;
        isCredits = false;
        Settings.gameObject.SetActive(true);
        ActivateUIObjects(isCredits, isSettings);
    }

    public void ReturnButtonSettings()
    {
        animatorControlSettings.SetBool("OutTransition", true);
        StartCoroutine(ShowButtonsAndText());
        DesactivateUIObject(isCredits, isSettings);
    }

    public void ReturnButtonCredits()
    {
        animatorControlCredits.SetBool("OutTransition", true);
        StartCoroutine(ShowButtonsAndText());
        DesactivateUIObject(isCredits, isSettings);
    }

    private void DesactivateUIObject(bool isCredits, bool isSettings)
    {
        if (isCredits)
        {
            for (int counting = 0; counting < TextAndButtonsCredits.Length; counting++)
            {
                TextAndButtonsCredits[counting].SetActive(false);
            }
        }
        if (isSettings)
        {
            for (int counting = 0; counting < TextAndButtonsSettings.Length; counting++)
            {
                TextAndButtonsSettings[counting].SetActive(false);
            }
        } 
    }

    private void ActivateUIObjects(bool isCredits, bool isSettings)
    {
        if (isCredits)
        {
            for (int counting = 0; counting < TextAndButtonsCredits.Length; counting++)
            {
                TextAndButtonsCredits[counting].SetActive(true);
            }
        }
        if (isSettings)
        {
            for (int counting = 0; counting < TextAndButtonsSettings.Length; counting++)
            {
                TextAndButtonsSettings[counting].SetActive(true);
            }
        }
    }

    IEnumerator ShowButtonsAndText()
    {
        yield return new WaitForSeconds(1.5f);
        if (isCredits)
        {
            Credits.gameObject.SetActive(false);
        }

        if(isSettings)
        {
            Settings.gameObject.SetActive(false);
        }
    }
}
