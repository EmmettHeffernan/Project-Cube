using UnityEngine;

public class Destructible : MonoBehaviour
{

    public GameObject destroyedVersion;
    public bool enable;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "Player")
        {
            if (enable)
            {
                Instantiate(destroyedVersion, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
    }

}
