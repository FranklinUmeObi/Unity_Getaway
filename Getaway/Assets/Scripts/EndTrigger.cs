using UnityEngine;

public class EndTrigger : MonoBehaviour
{
   public GameStateManager manager;

   // Start is called before the first frame update
   void OnTriggerEnter()
   {
      manager.CompleteLevel();
   }
}
