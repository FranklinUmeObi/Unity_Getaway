using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
   public float restartDelay = 1.3f;
   bool ended = false;
   public GameObject winPanel;

   private AudioSource audioSource;
   // Start is called before the first frame update
   void Start()
   {
      audioSource = GetComponent<AudioSource>();
   }

   public void GameOver()
   {
      if (ended == false)
      {
         Debug.Log("GameOver");
         Invoke("Restart", restartDelay);
      }
      ended = true;
   }

   public void CompleteLevel()
   {
      Debug.Log("W");
      winPanel.SetActive(true);
   }

   void Restart()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
