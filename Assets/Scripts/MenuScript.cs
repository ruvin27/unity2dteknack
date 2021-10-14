using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuScript : MonoBehaviour
{
    public InputField Username;
    public GameObject StartBtn;
    public void OnStartPressed(){
        SceneManager.LoadScene("Main Game");
    }

    void Update(){
        if(Username.text.Length >= 3){
            StartBtn.SetActive(true);
        }
        else{
            StartBtn.SetActive(false);
        }
    }
}
