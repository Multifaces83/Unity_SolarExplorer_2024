using UnityEngine;

public class CanonMovement : MonoBehaviour
{
    [SerializeField] private Transform _camera;
    private void Update()
    {
        Vector3 direction = _camera.position - transform.position;

        Quaternion targetRotation = Quaternion.LookRotation(direction);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 1f);
    }

}
