using System;
using UnityEngine;

public class PetManager : MonoBehaviour
{
    public static PetManager instance;
    public static PetController petController;
    public static NeedController needsController;
    public static InventaryController inventaryController;
    public Action eventEatFood;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
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
    public void Die()
    {
        Debug.Log("The pet just died.");
    }

}
