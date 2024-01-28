// using UnityEngine;

// public class LimitedRotation : MonoBehaviour
// {
//     public float _xRotation { get; private set; }
//     public float _zRotation { get; private set; }

//     [SerializeField] private float _maxAngle = 45.0f;
//     [SerializeField] private float _minAngle = 45.0f;

//     private void Update()
//     {
//         _xRotation = transform.rotation.eulerAngles.x;
//         _zRotation = transform.rotation.eulerAngles.z;

//         if (_xRotation > 180.0f)
//             _xRotation -= 360.0f;
//         if (_zRotation > 180.0f)
//             _zRotation -= 360.0f;

//         if (_xRotation < -180.0f)
//             _xRotation += 360.0f;
//         if (_zRotation < -180.0f)
//             _zRotation += 360.0f;

//         if (_xRotation > _maxAngle)
//             _xRotation = _maxAngle;
//         else if (_xRotation < -_maxAngle)
//             _xRotation = -_maxAngle;

//         if (_zRotation > _maxAngle)
//             _zRotation = _maxAngle;
//         else if (_zRotation < -_maxAngle)
//             _zRotation = -_maxAngle;

//         transform.rotation = Quaternion.Euler(_xRotation, 0.0f, _zRotation);
//     }




using UnityEngine;

public class LimitedRotation : MonoBehaviour
{
    public float _xRotation { get; private set; }
    public float _zRotation { get; private set; }

    [SerializeField] private float _maxAngle = 45.0f;

    private void Update()
    {

        Quaternion currentRotation = transform.rotation;

        Vector3 currentEulerAngles = currentRotation.eulerAngles;

        float limitedX = currentEulerAngles.x;
        float limitedZ = currentEulerAngles.z;

        limitedX = CustomClampAngle(limitedX, -_maxAngle, _maxAngle);
        limitedZ = CustomClampAngle(limitedZ, -_maxAngle, _maxAngle);

        Quaternion limitedRotation = Quaternion.Euler(limitedX, 0.0f, limitedZ);

        transform.rotation = limitedRotation;

        _xRotation = limitedX;
        _zRotation = limitedZ;
    }

    private float CustomClampAngle(float angle, float min, float max)
    {
        if (angle < -180.0f)
            angle += 360.0f;
        if (angle > 180.0f)
            angle -= 360.0f;

        return Mathf.Clamp(angle, min, max);
    }
}

