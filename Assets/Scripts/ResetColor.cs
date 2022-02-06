using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetColor : MonoBehaviour
{
    Material material;
    Light light;
    Color originalColor = new Color32(255, 134, 0, 255);

    private void Start()
    {
        material = GetComponent<Renderer>().material;
        light = GetComponentInChildren<Light>();
    }

    public void Reset()
    {
        material.color = originalColor;
        material.SetColor("_EmissionColor", originalColor * 1);
        light.color = originalColor;
    }
}
