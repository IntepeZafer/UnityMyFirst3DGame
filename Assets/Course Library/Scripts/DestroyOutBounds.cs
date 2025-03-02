using UnityEngine;

public class DestroyOutBounds : MonoBehaviour
{
    public float topBound;
    public float lowerBound;
    private void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
    }
}
