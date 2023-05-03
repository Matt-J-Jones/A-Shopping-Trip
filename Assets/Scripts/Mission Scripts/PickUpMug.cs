using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpMug : MonoBehaviour
{
    public Item Item_Activate; //Item to be activated
    public Item Item_Deactivate; //Item to be deactivated
    public Item List_Activate; //Item to be activated
    public Item List_Deactivate; //Item to be deactivated
    public bool PlayerInTrigger = false; // Player is in collider

    public Item Text;
    public Item Next_Mission;
    
    void Update()
    {
      if (PlayerInTrigger &&
          Input.GetKeyDown(KeyCode.E)) // check that player is in range and has pressed 'E' Key
      {
        Item_Deactivate.gameObject.SetActive(false); // Deactivate world object
        Item_Activate.gameObject.SetActive(true);
        Text.gameObject.SetActive(false);
        Next_Mission.gameObject.SetActive(true);
        gameObject.SetActive(false);
      }
    }

    void OnTriggerEnter2D(Collider2D other) // Player has entered collider
    {
      PlayerInTrigger = true; //Set variable
      List_Deactivate.gameObject.SetActive(false);
      List_Activate.gameObject.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D other) // Player leaves collider
    {
      PlayerInTrigger = false; //unset variable
      Text.gameObject.SetActive(false);
    }
}
