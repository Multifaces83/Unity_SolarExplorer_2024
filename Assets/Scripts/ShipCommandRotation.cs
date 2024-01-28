using UnityEngine;

public class ShipCommandRotation : MonoBehaviour
{
    public float _xRotation { get; private set; }
    public float _yRotation { get; private set; }
    public float _zRotation { get; private set; }

    // Update is called once per frame
    void Update()
    {
        Vector3 eulerAngles = GetRotationFromQuaternion(transform.rotation);

        _xRotation = eulerAngles.x;
        _yRotation = eulerAngles.y;
        _zRotation = eulerAngles.z;
    }

    private Vector3 GetRotationFromQuaternion(Quaternion quaternion)
    {
        return quaternion.eulerAngles;
        // Utilisez plutôt la fonction suivante pour obtenir des angles d'Euler plus stables :
        // return quaternion.ToEulerAngles().eulerAngles;
    }
}
