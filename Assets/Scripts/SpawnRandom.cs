using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandom : MonoBehaviour
{
    public GameObject[] objects;
    public Transform[] spawnPoints;
    [SerializeField]  MiniGameController   controller;


    public void Start()
    {
        StartCoroutine(IEspawnItem());
    }

    IEnumerator IEspawnItem()
    {
        while(!controller.isEndGame)
        {
            yield return new WaitForSeconds(1f);
            int random = Random.Range(0, objects.Length);
            GameObject ob= Instantiate(objects[random], spawnPoints[Random.Range(0, spawnPoints.Length)].position, Quaternion.identity);
            ob.transform.localScale = new Vector3(0.4F, 0.4F);
        }
    }
}
