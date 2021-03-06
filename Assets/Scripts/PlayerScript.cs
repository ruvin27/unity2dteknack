using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    public float MoveSpeed = 5f;
    public float JumpForce = 5f;
    public SpriteRenderer sr;
    private Animator myAnimation;
    public static int coins;
    public Text CoinText;



    // Start is called before the first frame update
    void Start()
    {
      coins = PlayerPrefs.GetInt("coins",0);
      rigidbody2D = GetComponent<Rigidbody2D>();
      myAnimation = GetComponent<Animator>();
      CoinText.text = "Coins: " + coins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(Input.GetAxisRaw("Horizontal"));
        Vector3 moveposition = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
        transform.position += moveposition * MoveSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, 0, 0);
        myAnimation.SetFloat("Speed", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
        if(Input.GetKeyDown(KeyCode.A)){
            sr.flipX = true;
        }
        else if (Input.GetKeyDown(KeyCode.D)){
            sr.flipX = false;
        }
        else if (Input.GetKeyDown(KeyCode.W)){
            Jump();
        }
        else if (Input.GetKeyDown(KeyCode.S)){
        }
        
        
        
    }

    void Jump(){
        rigidbody2D.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
    }

    public void BacktoMenu(){
        SceneManager.LoadScene("Menu");
    }

   
}
