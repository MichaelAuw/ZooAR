using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swipe : MonoBehaviour
{
    public GameObject scrollbar;
    float scroll_pos = 0;
    float[]pos;

    // bool Sun = false;
    // bool Mercury;
    // bool Venus;
    // Start is called before the first frame update
    void Start()
    {   
    }

    // Update is called once per frame
    void Update()
    {   
        // Debug.Log(Start_Manager.Earth);
        pos = new float[transform.childCount];
        float distance = 1f/(pos.Length - 1f);
        for(int i = 0 ; i < pos.Length; i++){
            pos[i] = distance * i ;
        }

        if(Input.GetMouseButton(0)){
            scroll_pos = scrollbar.GetComponent<Scrollbar>().value;
            Start_Manager.Highlight = 0;
            Start_Manager.Active = false;
        }else{
            for(int i = 0 ; i < pos.Length; i++){
                if(Start_Manager.Active){
                    if(scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance/2)){
                        scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, pos[Start_Manager.Highlight], 0.1f);
                    }
                }
                else{
                    if(scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance/2)){
                        scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, pos[i], 0.1f);
                    }   
                }
            }
        }
        
        for(int i = 0 ; i < pos.Length; i++){
            if(scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance/2)){
                if(i!=6)
                  transform.GetChild(i).localScale = Vector2.Lerp(transform.GetChild(i).localScale, new Vector2(1f,1f),0.1f);
                else
                  transform.GetChild(i).localScale = Vector2.Lerp(transform.GetChild(i).localScale, new Vector2(1.9f,1.2f),0.1f);
                for(int j = 0 ;j < pos.Length; j++){
                    if(j!=i){
                        transform.GetChild (j).localScale = Vector2.Lerp(transform.GetChild(j).localScale,new Vector2(0.8f,0.8f),0.1f);
                    }
                }
            }
        }
    }
}
