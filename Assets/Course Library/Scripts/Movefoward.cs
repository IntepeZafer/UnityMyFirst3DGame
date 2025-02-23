using UnityEngine;

public class Movefoward : MonoBehaviour
{
    public float speed;
    public float randomSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        randomSpeed = Random.Range(1f, 10f);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
