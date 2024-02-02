// using UnityEngine;

// public class Orbit : MonoBehaviour
// {
//     [SerializeField] private Transform _planet;
//     [SerializeField] private float _orbitSpeed = 1f;
//     [SerializeField] private float orbitRadius = 1f;

//     void Update()
//     {
//         transform.RotateAround(_planet.position, Vector3.up, _orbitSpeed * Time.deltaTime);

//         Vector3 orbitPosition = (transform.position - _planet.position).normalized * orbitRadius + _planet.position;
//         transform.position = orbitPosition;
//     }
// }

using UnityEngine;

public class Orbit : MonoBehaviour
{
    [SerializeField] private Transform _planet;
    [SerializeField] private float _orbitSpeed = 1f;
    [SerializeField] private float orbitRadiusX = 1f; // Semi-major axis
    [SerializeField] private float orbitRadiusZ = 0.5f; // Semi-minor axis

    private float currentAngle = 0f;

    void Start()
    {
        // Position initiale en orbite
        UpdateOrbitPosition();
    }

    void Update()
    {
        currentAngle += _orbitSpeed * Time.deltaTime;

        // Mettez à jour la position en orbite
        UpdateOrbitPosition();

        // Vous pouvez également ajouter une rotation pour aligner votre objet avec la tangente à l'orbite.
        transform.rotation = Quaternion.LookRotation((_planet.position - transform.position).normalized, Vector3.up);
    }

    void UpdateOrbitPosition()
    {
        float x = Mathf.Cos(currentAngle) * orbitRadiusX;
        float z = Mathf.Sin(currentAngle) * orbitRadiusZ;
        Vector3 orbitPosition = new Vector3(x, 0f, z) + _planet.position;
        transform.position = orbitPosition;
    }
}
