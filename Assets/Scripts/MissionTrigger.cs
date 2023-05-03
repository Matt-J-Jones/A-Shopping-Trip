using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionTrigger : MonoBehaviour
{
    public Item List_Deactivate; //Item to be deactivated
    public Item List_Activate; //Item to be activated
    public Item Text;
    public bool PlayerInTrigger = false; // Player is in collider
    public bool PlayerLeftTrigger = false;

    public Item Next_Mission;
    
    void Update()
    {
      if (PlayerInTrigger) // check that player is in range and has pressed 'E' Key
      {
        List_Deactivate.gameObject.SetActive(false); // Deactivate world object
        List_Activate.gameObject.SetActive(true); // Activate held object
        Text.gameObject.SetActive(true); 
        PlayerLeftTrigger = true;
      }

      if (PlayerLeftTrigger && !PlayerInTrigger)
      {
        Text.gameObject.SetActive(false); 
        gameObject.SetActive(false);
        Next_Mission.gameObject.SetActive(true);
      }
    }

    void OnTriggerEnter2D(Collider2D other) // Player has entered collider
    {
      PlayerInTrigger = true; //Set variable
    }

    void OnTriggerExit2D(Collider2D other) // Player leaves collider
    {
      PlayerInTrigger = false; //unset variable
    }
}
