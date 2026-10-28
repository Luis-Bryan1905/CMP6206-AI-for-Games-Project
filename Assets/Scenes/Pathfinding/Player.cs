using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    float x = 0.0f;
    float y = 0.0f;
    float z = 0.0f; 
    public int Speed = 3;

    public float MaxX = 0.0f;
    public float MaxZ = 0.0f;
    public float MinX = 0.0f;
    public float MinZ = 0.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (position.z < MinZ)
            {
                position.z += Speed * Time.deltaTime;
            }
            
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (position.z > MaxZ)
            {
                position.z += -Speed * Time.deltaTime;
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (position.x > MaxX)
            {
                position.x += -Speed * Time.deltaTime;
            }
            
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (position.x < MinX)
            {
                position.x += Speed * Time.deltaTime;
            }
        }


        transform.position = position;

    }
}
