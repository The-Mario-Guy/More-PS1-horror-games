using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxExposure : MonoBehaviour
{
    [SerializeField] private Material skybox;
    private float _elapsedTime = 0f;
    private float _timescale = 999f;
    private static readonly int rotation = Shader.PropertyToID("_Rotation");
    private static readonly int Exposure = Shader.PropertyToID("_Exposure");

    // Update is called once per frame
    void Update()
    {
        _elapsedTime += Time.deltaTime;
        skybox.SetFloat(rotation, _elapsedTime * _timescale);
        skybox.SetFloat(Exposure, Mathf.Clamp(Mathf.Sin(_elapsedTime), 0.15f, 1f));
    }
}
