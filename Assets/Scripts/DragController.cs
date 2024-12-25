using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DragController : MonoBehaviour
{
    FoodController foodController;

    private void Start()
    {
        foodController = FindObjectOfType<FoodController>();
    }

    public void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log($"Colisión con: {collision.gameObject.name}");

        //if(isEaten) return;
        //if(PetManager.petController.isFull == true) return;

        if (collision.collider.CompareTag("Mouth"))
        {
            Debug.Log(foodController.name);
            PetManager.needsController.ChangeFood(--foodController.hungerAmount);

            //GameManager.Instance.eventEatFood.Invoke();
        }
    }
}
