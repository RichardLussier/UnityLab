using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    
    [SerializeField] private Button startButton;
    [SerializeField] private Button creditsButton;
    [SerializeField] private Button exitButton;
    [SerializeField] private GameObject creditsUI;

    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(() => LoadingScreen.LoadScene("SampleScene"));
        creditsButton.onClick.AddListener(() => creditsUI.SetActive(true));
        exitButton.onClick.AddListener(() => creditsUI.SetActive(false));
    }
}
