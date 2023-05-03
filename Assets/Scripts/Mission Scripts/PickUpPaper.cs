using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpPaper : MonoBehaviour
{
    public Item Item_Activate; //Item to be activated
    public Item Item_Deactivate; //Item to be deactivated
    public bool PlayerInTrigger = false; // Player is in collider

    public Item Help;
    public Item Next_Mission;
    
    void Update()
    {
      if (PlayerInTrigger &&
          Input.GetKeyDown(KeyCode.E)) // check that player is in range and has pressed 'E' Key
      {
        Item_Deactivate.gameObject.SetActive(false); // Deactivate world object
        Item_Activate.gameObject.SetActive(true);
        gameObject.SetActive(false);
        Next_Mission.gameObject.SetActive(true);
      }
    }

    void OnTriggerEnter2D(Collider2D other) // Player has entered collider
    {
      PlayerInTrigger = true; //Set variable
      Help.gameObject.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D other) // Player leaves collider
    {
      PlayerInTrigger = false; //unset variable
      Help.gameObject.SetActive(false);
    }
}
