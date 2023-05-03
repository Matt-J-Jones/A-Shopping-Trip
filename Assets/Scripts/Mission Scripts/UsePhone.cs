using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsePhone : MonoBehaviour
{
    public bool PlayerInTrigger = false;
    public Item Text;
    public Item OldList;
    public Item PizzaList;
    public Item FadeOut;

    void Update()
    {
        if (PlayerInTrigger)
        {
          OldList.gameObject.SetActive(false);
          PizzaList.gameObject.SetActive(true);
        }
        
        if (PlayerInTrigger && Input.GetKeyDown(KeyCode.E))
        {
            Text.gameObject.SetActive(false);
            FadeOut.gameObject.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D other) // Player has entered collider
    {
      Text.gameObject.SetActive(true);
      PlayerInTrigger = true; //Set variable
    }

    void OnTriggerExit2D(Collider2D other) // Player leaves collider
    {
      PlayerInTrigger = false; //unset variable
    }
}
