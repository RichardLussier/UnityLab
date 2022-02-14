using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    
    [SerializeField] private Button startButton;
    [SerializeField] private Button openNotQuitePlatformer;
    [SerializeField] private Button open3DSpawn;


    [SerializeField] private Button creditsButton;
    [SerializeField] private Button exitButton;
    [SerializeField] private GameObject creditsUI;

    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(() => LoadingScreen.LoadScene("SampleScene"));
        openNotQuitePlatformer.onClick.AddListener(() => LoadingScreen.LoadScene("NotQuitePlatformer"));
        open3DSpawn.onClick.AddListener(() => LoadingScreen.LoadScene("3DSpawn"));
	creditsButton.onClick.AddListener(() => creditsUI.SetActive(true));
        exitButton.onClick.AddListener(() => creditsUI.SetActive(false));
    }
}
