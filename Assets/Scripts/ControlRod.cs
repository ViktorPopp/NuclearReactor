using UnityEngine;

public class ControlRod : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ThermalNeutron") || collision.gameObject.CompareTag("FastNeutron"))
        {
            Destroy(collision.gameObject);
        }
    }
}
