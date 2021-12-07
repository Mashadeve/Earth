using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameData : MonoBehaviour
{
    public string playerNickname;

    [System.Serializable]
    public class SaveData
    {
        public string playerNickname;
        //public int highscore;

    }
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

        Debug.Log("Kutsutaan load metodia");
    }


}
