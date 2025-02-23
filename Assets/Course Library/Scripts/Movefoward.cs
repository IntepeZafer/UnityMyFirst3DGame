using UnityEngine;

public class Movefoward : MonoBehaviour
{
    public float speed = 10.0f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
