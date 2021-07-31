using UnityEngine;

public class CameraClippingManager : MonoBehaviour
{
    [SerializeField] private float _cameraClipping = 1000f;
    [SerializeField] private Camera _camera;

    void Awake()
    {
        _camera.farClipPlane = _cameraClipping;
        RenderSettings.fogEndDistance = _cameraClipping;
    }
}
