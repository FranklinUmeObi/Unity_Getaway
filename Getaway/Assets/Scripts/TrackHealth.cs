using UnityEngine;
using UnityEngine.UI;


public class TrackHealth : MonoBehaviour
{
   public PlayerCollisions collision;
   public Text healthText;

   // Update is called once per frame
   void Update()
   {
      healthText.text = collision.health.ToString("0");
   }
}
