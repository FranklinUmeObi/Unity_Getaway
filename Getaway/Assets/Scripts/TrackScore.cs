using UnityEngine;
using UnityEngine.UI;


public class TrackScore : MonoBehaviour
{
   public Transform player;
   public Text scoreText;

   // Start is called before the first frame update
   void Start()
   {
   }

   void Update()
   {
      float score = (player.position.z / 8);

      scoreText.text = score.ToString("0");
      //GUIUtility.ExitGUI();
   }
}
