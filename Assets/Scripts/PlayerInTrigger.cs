using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInTrigger : MonoBehaviour
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

}
