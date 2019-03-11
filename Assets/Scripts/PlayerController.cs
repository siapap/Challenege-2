using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    //wahaha
    private Rigidbody2D rb2d;

    //speed variable
    public float speed;
    public float jumpPower;

    //count stuff
    private int count;
    public Text countText;
    public Text winText;



    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        count = 0;
        winText.text = " ";
        SetCountText();


    }

    // Update is called once per frame
    void Update()
    {
     
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
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if(count >= 4)
        {
            winText.text = "YOU WIN!";
        }
    }

}
