using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{

    public enum FoodType
    {
        HEALTHY,
        UNHEALTHY
    }

    public enum FoodCategory
    {
        PROTEIN,
        FRUIT,
        VEGETABLE,
        CARBOHYDRATE,
        FAT,
        SWEET
    }

    public FoodType type;

    public FoodCategory category;

    public int hungerAmount;

    public int hapinessAmount;

    public int vitalityAmount;

    public int cost;

    public new string name;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
