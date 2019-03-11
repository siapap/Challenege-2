using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //wahaha
    private Rigidbody2D rb2d;

    //speed variable
    public float speed;
    public float jumpPower;

    //count stuff
    static private int count;
    public Text winText;
    //don't need count text anymore so that's ok

    //to display health
    public Image heartDisplay;


    //life
    public int currHealth;
    public int maxHealth;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        winText.text = " ";
       

        //health
        maxHealth = 3;
        //at start of the game
        currHealth = maxHealth;

        Debug.Log(count);

    }

    // Update is called once per frame
    void Update()
    {
        //making sure the current health doesn't exceed max
     if(currHealth > maxHealth)
        {
            currHealth = maxHealth;
        }

        //for death
        if (currHealth == 0)
        {
            SceneManager.LoadScene("Game Over!", LoadSceneMode.Single);
        }
    }

    //here for physics babies
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(moveHorizontal, 0);
        rb2d.AddForce(movement * speed);

        //for jumping
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(Vector2.up * jumpPower);
        }


    }

    //for picking up collectibles
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count =  count + 1;
            SetWinText();
        }

        if(other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
            currHealth = currHealth - 1;
        }
    }

    void SetWinText()
    {
        //need to change this so that it references the 

        if (count == 4 && currHealth >= 1)
        {
            SceneManager.LoadScene("Level2");
        }

        if (count == 8 && currHealth >= 1)
        {
            SceneManager.LoadScene("Win Scene");
        }
    }

}
