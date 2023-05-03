using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnTV : MonoBehaviour
{
    public bool PlayerInTrigger = false;
    public Item Text;
    public Item TVScreen;
    public Item Phone;
    public Item PizzaText;

    void Update()
    {
        if (PlayerInTrigger && Input.GetKeyDown(KeyCode.E))
        {
            TVScreen.gameObject.SetActive(true);
            Phone.gameObject.SetActive(true);
            PizzaText.gameObject.SetActive(true);
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
