using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameController : MonoBehaviour
{
    public bool isEndGame;
    public float timeCount = 120;
    private void OnEnable()
    {
        isEndGame = false;
    }

    private IEnumerator CountDown()
    {
        while(timeCount > 0)
        {
            yield return new WaitForSeconds(10);
            timeCount-=10;

            if(timeCount == 0)
            {
                isEndGame = true;
            }
        }


    }
}
