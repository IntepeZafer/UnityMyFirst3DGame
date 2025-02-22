using UnityEngine;

public class FollowScript : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 6, -9);

    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
