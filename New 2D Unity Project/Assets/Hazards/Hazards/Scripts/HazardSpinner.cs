using UnityEngine;

public class HazardSpinner : MonoBehaviour
{
    public Transform pivot;

    [Range(0,10)]
    public float speed;

    public bool isClockwise;

    private void Update()
    {
        if (isClockwise)
        {
            pivot.Rotate(Vector3.back * speed);
        }
        else
        {
            pivot.Rotate(Vector3.forward * speed);
        }
    }
}
