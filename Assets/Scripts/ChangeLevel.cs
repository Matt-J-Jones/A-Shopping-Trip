using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{

    public string NewScene;
    public bool Trigger = false;
    
    void Update()
    {
      if (Trigger)
      {
        SceneManager.LoadScene(NewScene);
      }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
      Trigger = true; //Set variable
    }

    // void OnTriggerExit2D(Collider2D other)
    // {
    //   Trigger = false; //unset variable
    // }
}
