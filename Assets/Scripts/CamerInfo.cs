using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using System.Data.Common;
using System.IO;
using UnityEngine.Rendering;
using System.Data;
[System.Serializable]
public class SaveData
{
    public string rot;
}
public class CamerInfo : MonoBehaviour
{
    [SerializeField]
    private Camera cam;

    string path;
    public List<SaveData> sdList = new List<SaveData>();

    private void Start()
    {
        path = Application.dataPath + "/data.json";
        StartCoroutine(SaveCoroutine());

    }

    void SaveDataJson(string rot)
    {
        SaveData sd = new SaveData();
        sd.rot = rot;
        sdList.Add(sd);
        string jsonData = JsonUtility.ToJson(sdList);


        //File.WriteAllText(path, jsonData);

        //if (!File.Exists(path))
        //{
        //    File.WriteAllText(path, jsonData);
        //}
        //else
        //{
        //    string alldata = File.ReadAllText(path);
        //    alldata += "\n" + jsonData;
        //    File.WriteAllText(path, jsonData);
        //}

    }



    IEnumerator SaveCoroutine()
    {
        while (true)
        {
            Debug.Log(cam.transform.rotation);
            SaveDataJson(cam.transform.rotation.ToString());
            yield return new WaitForSeconds(1f);
            //
        }
    }


}
