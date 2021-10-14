using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CoinScript : MonoBehaviour
{
    public Text CoinText;

    private void OnCollisionEnter2D(Collision2D other){
        PlayerScript.coins += 1;
        Debug.Log(PlayerScript.coins);
        // CoinText.text = PlayerScript.ToString();
        CoinText.text = "Coins: " + PlayerScript.coins.ToString();
        PlayerPrefs.SetInt("coins",PlayerScript.coins);
        Destroy(gameObject);
    }
}
