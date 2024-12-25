using System;

[Serializable]

public class Pet
{
    public string lastTimeFed;
    public string lastTimeHappy;
    public string lastTimeGainedEnergy;
    public int food;
    public int happyness;
    public int energy;

    public Pet(string lastTimeFed,
        string lastTimeHappy,
        string lastTimeGainedEnergy,
        int food,
        int happyness,
        int energy)
    {
        this.lastTimeFed = lastTimeFed;
        this.lastTimeHappy = lastTimeHappy;
        this.lastTimeGainedEnergy = lastTimeGainedEnergy;
        this.food = food;
        this.happyness = happyness;
        this.energy = energy;
    }
}


