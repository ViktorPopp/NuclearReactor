using UnityEngine;

public class FastNeutron : MonoBehaviour
{
    [SerializeField] private float speed;
    public float hitsLeft = 18;
    private new Transform transform;

    private void Start()
    {
        hitsLeft = 18;
        transform = GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        transform.position += speed * Time.deltaTime * transform.up;
    }
}
