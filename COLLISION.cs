
using UnityEngine;

public class COLLISION : MonoBehaviour{
    public PlayerMovement movement;
    public Rigidbody rb;
    public Rigidbody Obstacle;
    public float forceUp = 10000f;

    public AudioSource collisionSound;
    
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Obstacle.useGravity = false;
            collisionSound = GetComponent<AudioSource>();
            collisionSound.Play();
            rb.useGravity = false;
            rb.AddForce(0, forceUp * Time.deltaTime, 0);
            movement.enabled = false;
            FindObjectOfType<GameMenager>().EndGame();
            FindObjectOfType<Score>().ColisionScore();
        }
    }
}
