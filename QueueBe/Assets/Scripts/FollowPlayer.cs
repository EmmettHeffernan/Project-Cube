
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    // Vector3 allows 3 variables to be defined for to be equal
    // to the camera position relative to the player
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;  
    }
}
 