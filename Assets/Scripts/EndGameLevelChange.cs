using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameLevelChange : MonoBehaviour
{
    public bool Trigger = false;
    public Item EndTrigger;
    
    void Update()
    {
      if (!EndTrigger.isActiveAndEnabled)
      {
        SceneManager.LoadScene("EndScreen");
      }
    }
}
