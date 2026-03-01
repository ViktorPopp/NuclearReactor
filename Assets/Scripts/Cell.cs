using UnityEngine;

public class Cell : MonoBehaviour
{
    public GameObject uranium;

    private void Update()
    {
        if (transform.Find("Uranium-235") == null)
        {
            if (Random.Range(0, 1650) == 0)
            {
                GameObject newChild = Instantiate(uranium, transform);
                newChild.name = "Uranium-235";
            }
        }
    }
}
