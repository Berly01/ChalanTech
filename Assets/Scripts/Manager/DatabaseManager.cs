using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{

    public static DatabaseManager instance;
    public NeedController needsController;
    private Database database;
    private const string FILE_NAME = "pet_info";

    private void Awake()
    {
        database = new Database();
        if (instance == null)
        {
            instance = this;
        }
        else Debug.LogWarning("More than one DatabaseManager in the Scene");
    }

    // Start is called before the first frame update
    void Start()
    {
        Pet pet = LoadPet();
        if (pet != null)
        {
            needsController.Initialize
                (
                pet.food,
                pet.happyness,
                pet.energy,
                10,
                10,
                10,
                DateTime.Parse(pet.lastTimeFed),
                DateTime.Parse(pet.lastTimeHappy),
                DateTime.Parse(pet.lastTimeGainedEnergy)
                );
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerManager.gameHourTimer < 0)
        {
            Pet pet = new Pet
                (
                needsController.lastTimeFed.ToString(),
                needsController.lastTimeHappy.ToString(),
                needsController.lastTimeGainedEnergy.ToString(),
                needsController.food,
                needsController.happiness,
                needsController.vitality
                );
            SavePet(pet);
            Debug.Log(FILE_NAME + " successfully was created");
        }

    }

    public void SavePet(Pet pet)
    {
        database.SaveData(FILE_NAME, pet);
    }

    public Pet LoadPet()
    {
        Pet returnedPet = null;

        database.LoadData<Pet>(FILE_NAME, ped =>
        {
            returnedPet = ped;
        });

        return returnedPet;
    }

}