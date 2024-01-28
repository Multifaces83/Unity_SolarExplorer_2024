// using UnityEngine;
// using UnityEngine.XR.Interaction.Toolkit;

// public class ShipHandleMovement : MonoBehaviour
// {
//     private XRGrabInteractable _grabInteractable;

//     [Header("References")]
//     [SerializeField] private GameObject _handleBaseSphere;

//     [SerializeField] private GameObject _handleBaseCylinder;

//     private XRGrabInteractable _handleBaseCylinderGrabInteractable;

//     [Header("Handle Base Sphere Rotations")]
//     [SerializeField] private float _xRotation;
//     [SerializeField] private float _yRotation;
//     [SerializeField] private float _zRotation;

//     [Header("Handle Base Sphere Restrictions")]
//     [SerializeField] private float _xRotationMax;
//     [SerializeField] private float _yRotationMax;
//     [SerializeField] private float _zRotationMax;

//     private void Start()
//     {
//         _handleBaseCylinderGrabInteractable = _handleBaseCylinder.GetComponent<XRGrabInteractable>();
//         _handleBaseSphere.transform.rotation = Quaternion.Euler(_xRotation, _yRotation, _zRotation);

//     }

//     private void ClampRotation()
//     {
//         _xRotation = Mathf.Clamp(_xRotation, -_xRotationMax, _xRotationMax);
//         _yRotation = Mathf.Clamp(_yRotation, -_yRotationMax, _yRotationMax);
//         _zRotation = Mathf.Clamp(_zRotation, -_zRotationMax, _zRotationMax);
//     }

//     public void RotateHandleBaseSphere(Vector3 rotation)
//     {
//         _xRotation += rotation.x;
//         _yRotation += rotation.y;
//         _zRotation += rotation.z;

//         ClampRotation();

//         _handleBaseSphere.transform.rotation = Quaternion.Euler(_xRotation, _yRotation, _zRotation);
//     }

//     public void RotateHandleBaseCylinder(Vector3 rotation)
//     {
//         _handleBaseCylinder.transform.Rotate(rotation);
//     }

//     public void SetHandleBaseCylinderGrabInteractable(XRGrabInteractable handleBaseCylinderGrabInteractable)
//     {
//         _handleBaseCylinderGrabInteractable = handleBaseCylinderGrabInteractable;
//     }

//     public void SetHandleBaseCylinderGrabInteractableEnabled(bool enabled)
//     {
//         _handleBaseCylinderGrabInteractable.enabled = enabled;
//     }
// }
