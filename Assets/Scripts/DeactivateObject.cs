using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateObject : MonoBehaviour
{
    public Item Item_Deactivate; //Item to be deactivated
    public bool PlayerInTrigger = false; // Player is in collider
    
    void Update()
    {
      if (PlayerInTrigger &&
          Input.GetKeyDown(KeyCode.E)) // check that player is in range and has pressed 'E' Key
      {
        Item_Deactivate.gameObject.SetActive(false); // Deactivate world object
        gameObject.SetActive(false);
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
