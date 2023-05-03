using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoDownstairs : MonoBehaviour
{
    public Item Door_Collider;
    public Item Closed_Door;
    public Item Open_Door;
    public Item Text;
    public bool PlayerInTrigger;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerInTrigger)
        {
            Door_Collider.gameObject.SetActive(false);
            Open_Door.gameObject.SetActive(true);
            Closed_Door.gameObject.SetActive(false);
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
