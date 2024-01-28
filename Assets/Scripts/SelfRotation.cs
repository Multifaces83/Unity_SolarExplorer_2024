using UnityEngine;

public class SelfRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 1f;
    [SerializeField] private Vector3 rotationAxis = Vector3.up;
    void Update()
    {
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
    }
}
