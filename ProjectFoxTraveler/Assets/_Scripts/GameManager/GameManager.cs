using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject Credits;
    public GameObject[] TextAndButtons;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

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

    IEnumerator ShowButtonsAndText()
    {
        yield return new WaitForSeconds(1f); 
    }
}
