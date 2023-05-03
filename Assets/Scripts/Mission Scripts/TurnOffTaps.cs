using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffTaps : MonoBehaviour
{
    public Item Help_Taps;
    public Item Tap_Text;
    public bool PlayerInTrigger;
    public Item Tap_Water;
    public Item TapListItem;

    public Item Legacy_Mission;
    public Item Next_Mission;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (PlayerInTrigger)
       {
         Tap_Text.gameObject.SetActive(false);
       } 

       if (!Tap_Water.isActiveAndEnabled)
       {
         Legacy_Mission.gameObject.SetActive(false);
       }

       if (PlayerInTrigger && Input.GetKeyDown(KeyCode.E))
       {
         Tap_Water.gameObject.SetActive(false);
         TapListItem.gameObject.SetActive(false);
         Next_Mission.gameObject.SetActive(true);
         gameObject.SetActive(false);
       }
    }

    void OnTriggerEnter2D(Collider2D other) // Player has entered collider
    {
      Help_Taps.gameObject.SetActive(true);
      
      PlayerInTrigger = true; //Set variable
    }

    void OnTriggerExit2D(Collider2D other) // Player leaves collider
    {
      PlayerInTrigger = false; //unset variable
    }
}
