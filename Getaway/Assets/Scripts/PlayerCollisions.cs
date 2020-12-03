using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
   // Start is called before the first frame update

   public Movement movement;
   public Rigidbody player;
   public float health = 100f;


   void OnCollisionEnter(Collision Collisioninfo)
   {
      if (Collisioninfo.collider.tag == "Obstacle")
      {
         Debug.Log("Bonk");
         movement.enabled = false;
         health           = 0f;
         FindObjectOfType<GameStateManager>().GameOver();
      }
      else if (Collisioninfo.collider.tag == "Wall")
      {
         float sideVelocity = Mathf.Abs(player.velocity.x);
         health = health - (22.2f * sideVelocity);
      }
      if (health < 1f)
      {
         movement.enabled = false;
         FindObjectOfType<GameStateManager>().GameOver();
      }
   }
}
