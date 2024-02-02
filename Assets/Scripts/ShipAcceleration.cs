using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShipAcceleration : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The ship transform that will updated and translated")]
    Transform m_ShipTransform;

    // [SerializeField] private float m_speed;
    [SerializeField] private AnimationCurve m_speedCurve;
    [SerializeField] private float m_maxSpeed;
    private float m_currentSpeed;
    private float m_TargetSpeed;
    private float m_KnobValue;

    void Update()
    {
        UpdateShipAcceleration();
    }

    // void UpdateShipAcceleration()
    // {
    //     var shipPosition = m_ShipTransform.localPosition;

    //     shipPosition += new Vector3(0f, 0f, m_KnobValue * m_speed * Time.deltaTime);

    //     m_ShipTransform.localPosition = shipPosition;
    // }
    // void UpdateShipAcceleration()
    // {
    //     var shipPosition = m_ShipTransform.localPosition;
    //     float speedMultiplier = m_speedCurve.Evaluate(m_KnobValue) * m_maxSpeed;

    //     shipPosition += new Vector3(0f, 0f, m_KnobValue * speedMultiplier * Time.deltaTime);

    //     m_ShipTransform.localPosition = shipPosition;
    // }

    void UpdateShipAcceleration()
    {
        var shipPosition = m_ShipTransform.localPosition;
        float speedMultiplier = m_speedCurve.Evaluate(m_KnobValue) * m_maxSpeed;
        m_TargetSpeed = m_KnobValue * speedMultiplier;

        m_currentSpeed = Mathf.Lerp(m_currentSpeed, m_TargetSpeed, Time.deltaTime);

        shipPosition += new Vector3(0f, 0f, m_currentSpeed * Time.deltaTime);

        m_ShipTransform.localPosition = shipPosition;

    }
    public void OnKnobValueChange(float value)
    {
        m_KnobValue = value;
    }
}