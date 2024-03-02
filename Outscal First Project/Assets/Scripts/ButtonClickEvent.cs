using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClickEvent : MonoBehaviour
{
    [SerializeField] Button nextButton;
    [SerializeField] Button backButton;
    [SerializeField] int nextSceneIndex;
  
    void OnNextButtonClick()
    {
        LoadScene(nextSceneIndex);
    }

    void OnBackButtonClick()
    {
        LoadScene(0);
    }

    void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

   
    // Start is called before the first frame update
    void Start()
    {
        nextButton.onClick.AddListener(OnNextButtonClick);
        backButton.onClick.AddListener(OnBackButtonClick); //Doubt
        
    }

}
