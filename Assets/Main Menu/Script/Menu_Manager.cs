using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu_Manager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Credits;
    

    // Start is called before the first frame update
    void Start()
    {
        MainMenu.SetActive(true);
        Credits.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButtonClicked(){
        SceneManager.LoadScene("Start");
    }

    public void CreditsButtonClicked(){
        MainMenu.SetActive(false);
        Credits.SetActive(true);
    }

    public void Quit_Clicked(){
        Application.Quit();
    }

    public void ReturnButton(){
        MainMenu.SetActive(true);
        Credits.SetActive(false);
    }
}
