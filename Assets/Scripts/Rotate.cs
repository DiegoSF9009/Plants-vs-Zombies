using UnityEngine;

public class Rotate : MonoBehaviour
{

   [SerializeField]
    private float rotationSpeed = 10f;



    void Update()
    {

        transform.Rotate(Vector3.up, rotationSpeed *Time.deltaTime);
        
    }
}
