using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    
    private MeshRenderer MyMeshRenderer;

    private MaterialPropertyBlock MaterialPropertyBlock;
    private void Awake()
    {
        MyMeshRenderer = GetComponent<MeshRenderer>();
        MaterialPropertyBlock = new MaterialPropertyBlock();
    }
    public Color CambiarColor()
    {
        Color ElColor = new Color();
        ElColor.g = Random.Range(0.0f, 1.0f);
        ElColor.a = Random.Range(0.0f, 1.0f);
        ElColor.b = Random.Range(0.0f, 1.0f);
        ElColor.r = Random.Range(0.0f, 1.0f);
        return ElColor;
    }
}
