using UnityEngine;

public class Movement : MonoBehaviour
{
   public Rigidbody player;

   public float forwardSpeed = 10f;
   public float sideSpeed    = 40f;
   public float maxSpeed     = 80f;

   private AudioSource audioSource;
   // Start is called before the first frame update
   void Start()
   {
      audioSource = GetComponent<AudioSource>();
   }

   // Update is called once per frame
   void FixedUpdate()
   {
      player.AddForce(0, 0, forwardSpeed * Time.deltaTime, ForceMode.VelocityChange);

      if (Input.GetKey("d")) { player.AddForce(sideSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange); }
      if (Input.GetKey("a")) { player.AddForce(-sideSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange); }
      if (player.position.y < -1f) { FindObjectOfType<GameStateManager>().GameOver(); }

      if (player.velocity.magnitude > maxSpeed * 1.1)
      {
         player.velocity = GetComponent<Rigidbody>().velocity.normalized *maxSpeed;
      }
   }
}
