using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItems : MonoBehaviour
{
    public Item Item_Deactivate; //Item to be deactivated
    public Item Item_Activate; //Item to be activated
    public bool PlayerInTrigger = false; // Player is in collider
    public bool PlayerLeftTrigger = false;
    public Item Help_Text;
    public Item Next_Text;
    public Item Next_Mission;
    public Item Initial_Text;
    public Item Initial_Objective;
    
    void Start()
    {
      Initial_Text.gameObject.SetActive(true);
      Initial_Objective.gameObject.SetActive(true);
    }
    
    void Update()
    {
      if (PlayerInTrigger &&
          Input.GetKeyDown(KeyCode.E)) // check that player is in range and has pressed 'Q' Key
      {
        Initial_Objective.gameObject.SetActive(false);
        Help_Text.gameObject.SetActive(false);
        Item_Deactivate.gameObject.SetActive(false); // Deactivate world object
        Item_Activate.gameObject.SetActive(true); // Activate held object
        PlayerLeftTrigger = true;
        Next_Text.gameObject.SetActive(true); 
        Next_Mission.gameObject.SetActive(true);
      }

      if (PlayerLeftTrigger && !PlayerInTrigger)
      {
        Next_Text.gameObject.SetActive(false); 
        gameObject.SetActive(false);
      }
    }

    void OnTriggerEnter2D(Collider2D other) // Player has entered collider
    {
      Initial_Text.gameObject.SetActive(false);
      Help_Text.gameObject.SetActive(true);
      PlayerInTrigger = true; //Set variable
    }

    void OnTriggerExit2D(Collider2D other) // Player leaves collider
    {
      Help_Text.gameObject.SetActive(false);
      PlayerInTrigger = false; //unset variable
    }
}
