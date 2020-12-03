using UnityEngine;
using UnityEngine.SceneManagement;


public class loadNextLevel : MonoBehaviour
{
   public void loadNextScene()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
