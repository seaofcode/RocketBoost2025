using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("On Friendly Platform");
                break;
            case "Fuel":
                Debug.Log("Got some Fuel");
                break;
            case "Finish":
                Debug.Log("Finished Level!");
                break;
            default:
                Debug.Log("Player Destroyed");
                break;
        }
    }

}
