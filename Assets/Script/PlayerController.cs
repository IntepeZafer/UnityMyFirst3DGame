using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        //transform.Translate(0 , 0 , 1f);
        transform.Translate(Vector3.forward * Time.deltaTime * 20f);
    }
}
