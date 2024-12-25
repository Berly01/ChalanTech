using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiningController : MonoBehaviour
{
    GameObject petObject = null;
    GameObject currentFoodObject = null;
    InventaryController inventaryController = null;
    int foodListindex = 0;

    const float X_POS = 0f;
    const float Y_POS = -4.5f;

    void Start()
    {
        petObject = GameObject.Find("Pet");
        inventaryController = petObject.gameObject.GetComponent<InventaryController>();
        currentFoodObject = GetFood(0);
    }

    private void Update()
    {
        
    }

    public void Next()
    {
        if (currentFoodObject != null)
        {
            Destroy(currentFoodObject);
        }

        if (foodListindex == inventaryController.FoodsList.Count)
        {
            foodListindex = 0;
        }
        else
        {
            ++foodListindex;
            currentFoodObject = GetFood(foodListindex);
        }
    }

    public void Before()
    {
        if (currentFoodObject != null)
        {
            Destroy(currentFoodObject);
        }

        if (foodListindex == 0)
        {
            foodListindex = inventaryController.FoodsList.Count - 1;
        }
        else
        {
            --foodListindex;
            currentFoodObject = GetFood(foodListindex);
        }
    }

    private GameObject GetFood(int index)
    {
        if (inventaryController != null 
            && inventaryController.FoodsList.Count != 0)
        {
            string path = "Foods/" + inventaryController.FoodsList[index];

            var prefab = Resources.Load<GameObject>(path);

            return Instantiate(prefab, new Vector3(X_POS, Y_POS, 0), Quaternion.identity);
        }

        return null;   
    }
}
