using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Start_Manager : MonoBehaviour
{

    public GameObject Return;

    //Highligh the last clicked Object
    public static int Highlight;
    public static bool Active;
    
    // Start is called before the first frame update
    public void SunClicked(){
        SceneManager.LoadScene("Hare");
        Active = true;
        Highlight = 0;
    }

    public void MercuryClicked(){
        SceneManager.LoadScene("Penguin");
        Active = true;
        Highlight = 1;
    }

    public void VenusClicked(){
        SceneManager.LoadScene("Polar_Bear");
        Active = true;
        Highlight = 2;
    }

    public void EarthClicked(){
        SceneManager.LoadScene("Seal");
        Active = true;
        Highlight = 3;
    }

    public void ReturnButton(){
        SceneManager.LoadScene("MainMenu");
    }
}
