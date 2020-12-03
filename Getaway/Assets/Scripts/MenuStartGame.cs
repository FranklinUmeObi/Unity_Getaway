using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuStartGame : MonoBehaviour
{
   public void loadNextScene()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
