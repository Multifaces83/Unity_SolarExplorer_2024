using UnityEngine;

public class Orbit : MonoBehaviour
{
    [SerializeField] private Transform _planet;
    [SerializeField] private float _orbitSpeed = 1f;
    [SerializeField] private float orbitRadius = 1f;

    void Update()
    {
        transform.RotateAround(_planet.position, Vector3.up, _orbitSpeed * Time.deltaTime);

        Vector3 orbitPosition = (transform.position - _planet.position).normalized * orbitRadius + _planet.position;
        transform.position = orbitPosition;
    }
}
