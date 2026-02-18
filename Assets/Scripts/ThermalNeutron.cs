using UnityEngine;

public class ThermalNeutron : MonoBehaviour
{
    [SerializeField] private float speed;
    private new Transform transform;

    private void Start()
    {
        transform = GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        transform.position += transform.up * Time.deltaTime * speed;
    }
}
