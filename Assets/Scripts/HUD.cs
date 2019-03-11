using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    //to change the sprite displayed
    public Sprite[] HeartSprites;

    //image on the screen for the UI
    public Image HeartUI;

    //to access to health of the player
    private PlayerController player;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        HeartUI.sprite = HeartSprites[player.currHealth];
    }

}
