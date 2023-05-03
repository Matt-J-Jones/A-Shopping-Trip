using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlaceItem : MonoBehaviour
{
    public bool PlayerInTrigger;
    public Item Deactivate;
    public Item Activate;
    public Item Text;

    // Update is called once per frame
    void Update()
    {
        if (PlayerInTrigger)
        {
            Deactivate.gameObject.SetActive(false);
            Activate.gameObject.SetActive(true);
            Text.gameObject.SetActive(true);
        }  
    }

    void OnTriggerEnter2D(Collider2D other) // Player has entered collider
    {
      PlayerInTrigger = true; //Set variable
    }

    void OnTriggerExit2D(Collider2D other) // Player leaves collider
    {
      PlayerInTrigger = false; //unset variable
      Text.gameObject.SetActive(false);
      gameObject.SetActive(false);
    }
}
