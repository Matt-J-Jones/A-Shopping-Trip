using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushTeeth : MonoBehaviour
{
    public Item Text; // Start text
    public Item Text_BuyToothpaste; // No Toothpaste Text
    public Item Text_TurnOffWater; // Forgot to turn off water text
    public Item List_Deactivate; // List to deactivate
    public Item List_Activate; // list to activate
    public Item Tap_Water; // gameobject running water
    public Item Brush_Teeth; // original "brush teeth" list item
    public Item Turn_Off_Water; // turn off the water list item
    public Item Buy_Toothpaste; // buy toothpaste list item
    public Item Help_Taps; // text to operate taps
    public Item Help_Brush; // text to brush teeth
    public Item Next_Mission;
    public bool PlayerInTrigger = false;
    public bool Tap = false; // is the tap running?
    


    
    
    // Start is called before the first frame update
    void Start()
    {
        Text.gameObject.SetActive(true);
        List_Activate.gameObject.SetActive(true);
        List_Deactivate.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerInTrigger && Input.GetKeyDown(KeyCode.E))
        {
            Text.gameObject.SetActive(false);
            Help_Taps.gameObject.SetActive(false);
            Tap_Water.gameObject.SetActive(true);
            Tap = true;
            Help_Brush.gameObject.SetActive(true);
        }

        if (PlayerInTrigger && Tap && Input.GetKeyDown(KeyCode.Q))
        {
            Help_Brush.gameObject.SetActive(false);
            Buy_Toothpaste.gameObject.SetActive(true);
            Text_BuyToothpaste.gameObject.SetActive(true);
            Next_Mission.gameObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other) // Player has entered collider
    {
      Help_Taps.gameObject.SetActive(true);
      PlayerInTrigger = true; //Set variable
    }

    void OnTriggerExit2D(Collider2D other) // Player leaves collider
    {
      PlayerInTrigger = false; //unset variable
    }
}
