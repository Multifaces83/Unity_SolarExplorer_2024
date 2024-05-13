using UnityEngine;

public class CanonBaseMovement : MonoBehaviour
{
    [SerializeField] private Transform _camera;

    private void Update()
    {
        Vector3 lookDirection = _camera.forward;

        lookDirection.y = 0;

        Quaternion targetRotation = Quaternion.LookRotation(lookDirection);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 1f);


    }
}
