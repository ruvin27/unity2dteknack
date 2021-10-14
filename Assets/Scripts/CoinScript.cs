using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D other){
        PlayerScript.coins += 1;
        Debug.Log(PlayerScript.coins);
        Destroy(gameObject);
    }
}
