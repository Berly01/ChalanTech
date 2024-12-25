using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerManager : MonoBehaviour
{

    public static float gameHourTimer;
    public float hourLenght;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (gameHourTimer <= 0)
        {
            gameHourTimer = hourLenght;
        }
        else
        {
            gameHourTimer -= Time.deltaTime;
        }

    }
}
