using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayManager : MonoBehaviour
{
    public GameObject Information;
    
    // Start is called before the first frame update
    void Start()
    {
        Information.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturnButtonClicked(){
        SceneManager.LoadScene("Start");
    }

    public void InformationButtonClicked(){
        if(Information.activeSelf == false){
             Information.SetActive(true);
        }
        else{
            Information.SetActive(false);
        }
    }
}
