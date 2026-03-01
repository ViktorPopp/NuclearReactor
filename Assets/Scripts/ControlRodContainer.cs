using UnityEngine;

public class ControlRodContainer : MonoBehaviour
{
    public float moveSpeed = 1f;

    void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("ThermalNeutron").Length + GameObject.FindGameObjectsWithTag("FastNeutron").Length;
        Debug.Log(count);

        float direction = (count < 40) ? moveSpeed : -moveSpeed;
        transform.Translate(direction * moveSpeed * Time.deltaTime * Vector3.up);

        float minY = 0f;
        float maxY = 10f;

        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        transform.position = pos;
    }
}