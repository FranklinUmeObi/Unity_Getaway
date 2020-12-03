using UnityEngine;

public class QuitApplication : MonoBehaviour
{
   public void QuitOutOfGame()
   {
      Debug.Log("Quit");
      Application.Quit();
   }
}
