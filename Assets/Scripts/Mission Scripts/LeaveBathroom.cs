using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveBathroom : MonoBehaviour
{
    public bool PlayerInTrigger = false;
    public Item Legacy_Text;
    public Item Tap_Text;
    public Item Next_Mission;
    

    public Item Tap_List_Item;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) // Player has entered collider
    {
      Legacy_Text.gameObject.SetActive(false); // clear "buy toothpaste" text
      PlayerInTrigger = true; //Set variable
    }

    void OnTriggerExit2D(Collider2D other) // Player leaves collider
    {
      Tap_Text.gameObject.SetActive(true); //display "did i turn the taps off" text
      Tap_List_Item.gameObject.SetActive(true); // add "turn taps off" objective.
      PlayerInTrigger = false; //unset variable
      Next_Mission.gameObject.SetActive(true); // load "turn off the taps" mission
      gameObject.SetActive(false);
      
    }
}
