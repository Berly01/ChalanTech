using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InventaryController : MonoBehaviour
{
    List<string> _foodsList = new List<string>();

    public List<string> FoodsList
    {
        get => _foodsList;
    }
    private void Awake()
    {
        string[] foods = { "BeefItem", "BreadItem", "ChickenItem", "HamburguerItem" };

        foreach (var item in foods)
        {
            _foodsList.Add(item);    
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
