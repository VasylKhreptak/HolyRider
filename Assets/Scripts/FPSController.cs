using UnityEngine;

public class FPSController : MonoBehaviour
{
    [SerializeField] private RCC_Settings _RCC_Settings;
    [SerializeField] private byte FPS = 60;

    void Awake()
    {
        Application.targetFrameRate = FPS;
        QualitySettings.vSyncCount = 0;

        _RCC_Settings.maxFPS = (int)FPS;
    }
}
