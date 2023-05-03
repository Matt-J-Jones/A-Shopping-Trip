using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{
    public Item ToBeActivated;
    public bool PlayerInTrigger;

    // Update is called once per frame
    void Update()
    {
        if (PlayerInTrigger)
        {
            ToBeActivated.gameObject.SetActive(true);
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
