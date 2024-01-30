using UnityEngine;

public class ShipRotation : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The ship transform that will updated and translated")]
    Transform m_ShipTransform;

    [SerializeField]
    [Tooltip("The speed at which the ship will rotate")]
    float m_RotationSpeed = 1.0f;

    [SerializeField]
    [Tooltip("The ship's minimum local")]
    float m_MinimumLocalRotation = -45.0f;

    [SerializeField]
    [Tooltip("The ship's maximum local")]
    float m_MaximumLocalRotation = 45.0f;

    Vector2 m_JoystickValue;

    private bool joystickActive = false;


    void Start()
    {

    }

    void Update()
    {
        UpdateShipRotation(m_RotationSpeed);
    }
    void UpdateShipRotation(float speed)
    {
        var shipRotation = m_ShipTransform.localRotation.eulerAngles;

        shipRotation += new Vector3(m_JoystickValue.y * speed * Time.deltaTime, 0f, m_JoystickValue.x * speed * Time.deltaTime);

        m_ShipTransform.localRotation = Quaternion.Euler(shipRotation);
    }

    public void OnJoystickValueChangeX(float x)
    {
        joystickActive = true;
        m_JoystickValue.x = x;
        Debug.Log("X: " + x);
    }

    public void OnJoystickValueChangeY(float y)
    {
        joystickActive = true;
        m_JoystickValue.y = y;
        Debug.Log("Y: " + y);
    }

}
