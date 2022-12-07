using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public PlayerMovement movement;
    public GameManager gameManager;
    public FallCheck fall;

    void OnTriggerEnter(Collider collider)
    {
        if (movement.alive)
        {
            if (collider.gameObject.tag == "Player")
            {
                gameManager.CompleteLevel();
                fall.enabled = false;
            }
        }
    }
}