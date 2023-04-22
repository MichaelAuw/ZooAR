using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Game_Return : MonoBehaviour
{
    // Start is called before the first frame update
    public void ReturnButtonClicked()
    {
       SceneManager.LoadScene("MainMenu");
    }
}
