using UnityEngine;

public class Water : MonoBehaviour
{
    [SerializeField] private float temp;
    public GameObject thermalNeutron;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("FastNeutron"))
        {
            var colScript = collision.gameObject.GetComponent<FastNeutron>();
            colScript.hitsLeft -= 4;
            if (colScript.hitsLeft <= 0)
            {
                Instantiate(thermalNeutron, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
                Destroy(collision.gameObject);
            }
        }
    }
}
