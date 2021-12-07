using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class SaveData : MonoBehaviour
{
    public string playerNickname;
    //public int highscore;

    public void SaveGame()
    {
        SaveData data = new SaveData();
        data.playerNickname = playerNickname;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            playerNickname = data.playerNickname;
        }

    }

}

