using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlmanacManager : MonoBehaviour
{

    private void Awake()
    {

        GameObject prefab = Resources.Load<GameObject>("Foods/AppleItem");
        
        if (prefab != null)
        {
            Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
        }
        else
        {
            Debug.LogError("No se pudo cargar el prefab. Verifica la ruta.");
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
