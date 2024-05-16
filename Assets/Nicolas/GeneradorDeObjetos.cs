using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorDeObjetos : MonoBehaviour
{
    [SerializeField] GameObject Prefab;
    [SerializeField] int x;
    [SerializeField] int z;
    [SerializeField] float distancia;
    [SerializeField] ChangeColor ChangeColor;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < x; i++)
        {
            for(int j = 0; j < z; j++)
            {
                GameObject ElObjeto = Instantiate(Prefab, new Vector3(i, 0, j)*distancia, Quaternion.identity);
                ElObjeto.GetComponent<Objetos>().ChangeColor = ChangeColor;
            }
        }
    }

}
