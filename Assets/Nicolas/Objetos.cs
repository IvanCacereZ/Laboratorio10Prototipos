using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetos : MonoBehaviour
{
    public ChangeColor ChangeColor;
    MeshRenderer MyMeshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        MyMeshRenderer = GetComponent<MeshRenderer>();
    }

    

    // Update is called once per frame
    void Update()
    {
        MyMeshRenderer.material.color = ChangeColor.CambiarColor();
    }
}
