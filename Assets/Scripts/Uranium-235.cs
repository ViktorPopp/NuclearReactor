using UnityEngine;

public class Uranium : MonoBehaviour
{
    public GameObject fastNeutron;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ThermalNeutron"))
        {
            Instantiate(fastNeutron, this.transform.position, Quaternion.Euler(0f, 0f, Random.Range(0f, 360f)));
            Instantiate(fastNeutron, this.transform.position, Quaternion.Euler(0f, 0f, Random.Range(0f, 360f)));
            Instantiate(fastNeutron, this.transform.position, Quaternion.Euler(0f, 0f, Random.Range(0f, 360f)));
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
