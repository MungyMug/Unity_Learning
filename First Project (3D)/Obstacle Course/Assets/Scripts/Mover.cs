using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10.0f;
    void Start()
    {
        PrintInstruction();
    }


    void Update()
    {
        movePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move using WASD or arrowkeys.");
        Debug.Log("Don't bump into object!");
    }

    void movePlayer()
    {
        float x_move = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float y_move = 0.0f;
        float z_move = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(x_move, y_move, z_move);
    }
}
