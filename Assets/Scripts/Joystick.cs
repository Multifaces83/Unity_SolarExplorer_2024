using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class Joystick : MonoBehaviour
{
    [SerializeField] private XRGrabInteractable _grabInteractable;
    [SerializeField] private GameObject _handleBaseSphere;
    [SerializeField] private float _xRotation;
    [SerializeField] private float _zRotation;
    [SerializeField] private float _xRotationMax;
    [SerializeField] private float _zRotationMax;
    [SerializeField] private float _maxMagnitude;

    private Quaternion _initialRotation;

    private bool _isReleasing = false;
    void Start()
    {
        _initialRotation = _handleBaseSphere.transform.rotation;
    }
    void Update()
    {
        if (_grabInteractable.isSelected)
        {
        }
        if (_isReleasing && !_grabInteractable.isSelected)
        {
            LerpToInitialRotation();
        }
    }

    private void OnEnable()
    {
        _grabInteractable.selectEntered.AddListener(OnGrab);
        _grabInteractable.selectExited.AddListener(OnRelease);
    }

    private void OnDisable()
    {
        _grabInteractable.selectEntered.RemoveListener(OnGrab);
        _grabInteractable.selectExited.RemoveListener(OnRelease);
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        _handleBaseSphere.GetComponent<Renderer>().material.color = Color.red;
    }

    private void OnRelease(SelectExitEventArgs args)
    {
        _isReleasing = true;
    }

    private void LerpToInitialRotation()
    {
        float lerpSpeed = 0.1f; // Ajustez la vitesse de lerp selon vos besoins
        _handleBaseSphere.transform.localRotation = Quaternion.Lerp(_handleBaseSphere.transform.rotation, _initialRotation, lerpSpeed);

    }

}

