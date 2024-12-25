using System.IO;
using UnityEngine;

public class Database
{

    private string path = Application.dataPath + "/Resources/Saves/";

    public void SaveData<T>(string saveName, T data)
    {
        string jsonToSave = JsonUtility.ToJson(data);
        File.WriteAllText(
            path + saveName + ".json",
            jsonToSave
            );

    }

    public void LoadData<T>(string saveName, System.Action<T> callback)
    {
        string filePath = path + saveName + ".json";

        if (File.Exists(filePath))
        {
            string loadedJson = File.ReadAllText(filePath);
            callback(JsonUtility.FromJson<T>(loadedJson));
        }
        else
        {
            Debug.Log("File does not exist");
        }
    }

}
