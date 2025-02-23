using UnityEngine;

public class PlayerControllers : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float xRange;
    public GameObject projectilePrefab;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange , transform.position.y, transform.position.z);
        }else if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }
}
