using System;
using System.Collections.Generic;
using UnityEngine;

public class NeedController : MonoBehaviour
{
    public int food;
    public int happiness;
    public int vitality;

    public int foodTickRate;
    public int happinessTickRate;
    public int vitalityTickRate;

    public DateTime lastTimeFed;
    public DateTime lastTimeHappy;
    public DateTime lastTimeGainedEnergy;

    public BarController hungerBar;
    public BarController hapinessBar;
    public BarController vitalityBar;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (TimerManager.gameHourTimer < 0)
        {
            ChangeFood(-foodTickRate);
            hungerBar.ChangeAmount(-foodTickRate);
            hungerBar.AmountBarFiller();
            hungerBar.ColorChanger();
        }
    }
    public void Initialize(int food, int hapiness, int vitality,
        int foodTickRate, int happinessTickRate, int vitalityTickRate)
    {
        DateTime now = DateTime.Now;
        lastTimeFed = now;
        lastTimeHappy = now;
        lastTimeGainedEnergy = now;
        this.food = food;
        this.happiness = hapiness;
        this.vitality = vitality;
        this.foodTickRate = foodTickRate;
        this.happinessTickRate = happinessTickRate;
        this.vitalityTickRate = vitalityTickRate;
    }
    public void Initialize(int food, int hapiness, int vitality,
        int foodTickRate, int happinessTickRate, int vitalityTickRate,
        DateTime lastTimeFed, DateTime lastTimeHappy, DateTime lastTimeGainedEnergy)
    {
        this.food = food;
        this.happiness = hapiness;
        this.vitality = vitality;
        this.foodTickRate = foodTickRate;
        this.happinessTickRate = happinessTickRate;
        this.vitalityTickRate = vitalityTickRate;
        this.lastTimeFed = lastTimeFed;
        this.lastTimeHappy = lastTimeHappy;
        this.lastTimeGainedEnergy = lastTimeGainedEnergy;
    }

    public void ChangeFood(int amount)
    {
        food += amount;

        if (food < 0)
        {
            PetManager.instance.Die();
        }
        else if (food == 100)
        {
            food = 100;
        }
    }

    public void ChangeHappiness(int amount)
    {
        happiness += amount;

        if (happiness < 0)
        {
            PetManager.instance.Die();
        }
        else if (happiness == 100)
        {
            happiness = 100;
        }
    }

    public void ChangeVitality(int amount)
    {
        vitality += amount;

        if (vitality < 0)
        {
            PetManager.instance.Die();
        }
        else if (vitality == 100)
        {
            vitality = 100;
        }
    }

}
