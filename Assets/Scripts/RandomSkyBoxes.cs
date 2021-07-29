using UnityEngine;

public class RandomSkyBoxes : MonoBehaviour
{
    [SerializeField] private Material []_skyBoxes;

    void Awake()
    {
        RenderSettings.skybox = _skyBoxes[Random.Range(0, _skyBoxes.Length - 1)];
    }
}
