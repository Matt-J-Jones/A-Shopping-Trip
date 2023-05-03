using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpTrash : MonoBehaviour
{
    public Item Item_Deactivate; //Item to be deactivated
    public Item Item_Activate; //Item to be activated
    public Item List_Deactivate; //Item to be deactivated
    public Item List_Activate; //Item to be activated
    public bool PlayerInTrigger = false; // Player is in collider
    public bool PlayerLeftTrigger = false;
    public Item Help_Text;
    public Item Text;

    public Item Next_Mission;
    
    void Update()
    {
      if (PlayerInTrigger &&
          Input.GetKeyDown(KeyCode.Q)) // check that player is in range and has pressed 'Q' Key
      {
        Help_Text.gameObject.SetActive(false);
        Item_Deactivate.gameObject.SetActive(false); // Deactivate world object
        Item_Activate.gameObject.SetActive(true); // Activate held object
        List_Deactivate.gameObject.SetActive(false); // Deactivate old list
        List_Activate.gameObject.SetActive(true); // Activate new list
        PlayerLeftTrigger = true;
        Text.gameObject.SetActive(true);
        Next_Mission.gameObject.SetActive(true);
      }

      if (PlayerLeftTrigger && !PlayerInTrigger)
      {
        Text.gameObject.SetActive(false); 
        gameObject.SetActive(false);
      }
    }

    void OnTriggerEnter2D(Collider2D other) // Player has entered collider
    {
      Help_Text.gameObject.SetActive(true);
      PlayerInTrigger = true; //Set variable
    }

    void OnTriggerExit2D(Collider2D other) // Player leaves collider
    {
      Help_Text.gameObject.SetActive(false);
      PlayerInTrigger = false; //unset variable
    }
}
