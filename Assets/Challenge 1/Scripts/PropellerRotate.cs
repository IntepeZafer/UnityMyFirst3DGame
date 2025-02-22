using UnityEngine;

public class PropellerRotate : MonoBehaviour
{
    private float rotationSpeed = 1000.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
    }
}
