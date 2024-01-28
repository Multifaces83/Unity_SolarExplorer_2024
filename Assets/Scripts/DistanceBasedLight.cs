using UnityEngine;

public class DistanceBasedLight : MonoBehaviour
{
    [SerializeField] private Transform _lightTransform;
    [SerializeField] private float intensityFactor = 1.0f;
    void Update()
    {
        float distance = Vector3.Distance(transform.position, _lightTransform.position);

        float adjustedIntensity = 1.0f / (distance * distance) * intensityFactor;
        Light light = _lightTransform.GetComponent<Light>();
        light.intensity = Mathf.Lerp(light.intensity, adjustedIntensity, 0.1f);


        //light.intensity = adjustedIntensity;
    }
}
