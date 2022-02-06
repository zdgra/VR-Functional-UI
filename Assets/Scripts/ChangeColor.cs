using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    Material material;
    Light light;

    private void Start()
    {
        material = GetComponent<Renderer>().material;
        light = GetComponentInChildren<Light>();
    }

    public void SetRandomColor()
    {
        material.color = new Color(Random.Range(0f, 1f),
                                   Random.Range(0f, 1f),
                                   Random.Range(0f, 1f),
                                   255);
        material.SetColor("_EmissionColor", material.color * 1);
        light.color = material.color;
    }
}
