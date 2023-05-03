using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SockPickup : MonoBehaviour
{
    public Item Item_Deactivate; //Item to be deactivated
    public Item Item_Activate; //Item to be activated
    public Item List_Deactivate; //List to be deactivated
    public Item List_Activate; //List to be activated

    public bool PlayerInTrigger = false; // Player is in collider
    public Item Next_Mission;
    public Item Next_M_Text;
    public Item Text;
    
    void Update()
    {
      if (PlayerInTrigger &&
          Input.GetKeyDown(KeyCode.E)) // check that player is in range and has pressed 'Q' Key
      {
        Item_Deactivate.gameObject.SetActive(false); // Deactivate world object
        Item_Activate.gameObject.SetActive(true); // Activate held object
        List_Deactivate.gameObject.SetActive(false); // Deactivate list
        List_Activate.gameObject.SetActive(true); // Activate List
        Text.gameObject.SetActive(false); 
        Next_Mission.gameObject.SetActive(true);
        Next_M_Text.gameObject.SetActive(true);
        gameObject.SetActive(false);
      }

    }

    void OnTriggerEnter2D(Collider2D other) // Player has entered collider
    {
      Text.gameObject.SetActive(true);
      PlayerInTrigger = true; //Set variable
    }

    void OnTriggerExit2D(Collider2D other) // Player leaves collider
    {
      Text.gameObject.SetActive(false);
      PlayerInTrigger = false; //unset variable
    }
}
