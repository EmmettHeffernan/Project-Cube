using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    
    public GameManager gameManager;

    void OnTriggerEnter(Collider collider) {
        // only triggers end game event if player hits the end
        if (collider.name == "Player") {
            gameManager.CompleteLevel();
        }
    }

}
