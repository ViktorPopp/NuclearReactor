using UnityEngine;

public class ControlRodContainer : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float moveY = 0f;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveY = 1f;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            moveY = -1f;
        }

        transform.Translate(moveSpeed * moveY * Time.deltaTime * Vector3.up);
    }
}