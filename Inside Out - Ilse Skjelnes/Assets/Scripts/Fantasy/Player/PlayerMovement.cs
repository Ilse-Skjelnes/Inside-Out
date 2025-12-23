using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private int movementSpeed = 1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Movement(Vector3.up);
            Debug.Log("Pressing W");
        }

        else if (Input.GetKey(KeyCode.S))
        {
            Movement(Vector3.down);
            Debug.Log("Pressing S");
        }

        if (Input.GetKey(KeyCode.A))
        {
            Movement(Vector3.left);
            Debug.Log("Pressing A");
        }

        else if (Input.GetKey(KeyCode.D))
        {
            Movement(Vector3.right);
            Debug.Log("Pressing D");
        }
    }

    private void Movement(Vector3 direction)
    {
        Vector3 position = transform.position;
        transform.position = position + direction * movementSpeed * Time.deltaTime;
    }

}
