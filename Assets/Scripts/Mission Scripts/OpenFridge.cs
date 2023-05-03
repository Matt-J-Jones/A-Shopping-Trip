using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFridge : MonoBehaviour
{
    public bool PlayerInTrigger = false;
    public Item Open_Fridge;
    public Item Close_Fridge;
    public Item Text;


    // Update is called once per frame
    void Update()
    {
        if (PlayerInTrigger && Input.GetKeyDown(KeyCode.E))
        {
            Open_Fridge.gameObject.SetActive(true);
            Close_Fridge.gameObject.SetActive(false);
            Text.gameObject.SetActive(false);
            
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
        Open_Fridge.gameObject.SetActive(false);
        Close_Fridge.gameObject.SetActive(true);

    }
}
