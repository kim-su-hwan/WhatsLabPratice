using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using System.Data.Common;
using System.IO;
using UnityEngine.Rendering;
using System.Data;
using System;
[System.Serializable]
public class SaveData
{
    public float rot_x;
    public float rot_y;
    public float rot_z;
    public string time;
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
        StartCoroutine(JsonSaveCoroutine());
        //StartCoroutine("SaveTheCoroutine");
    }

    //void SaveDataJson(SaveData rot)
    //{
    //    //SaveData sd = new SaveData();
    //    //sd.rot = rot;
    //    //rot += "\n";
    //    string jsonData = JsonUtility.ToJson(rot);
    //    Debug.Log("--------" + jsonData);
    //    File.WriteAllText(path, jsonData);
    //    //if (!File.Exists(path))
    //    //{
    //    //    File.WriteAllText(path, jsonData);
    //    //}
    //    //else
    //    //{
    //    //    //string alldata = File.ReadAllText(path);
    //    //    //alldata += "\n" + jsonData;
    //    //    File.AppendText(jsonData);
    //    //    //File.WriteAllText(path, jsonData);
    //    //}

    //}

    void SaveDataJson(Quaternion rot)
    {
        //SaveData sd = new SaveData();
        //sd.rot = rot;
        //rot += "\n";
        SaveData sd = new SaveData();
        sd.rot_x = rot.x;
        sd.rot_y = rot.y;
        sd.rot_z = rot.z;
        sd.time = DateTime.Now.ToString();
        string jsonData = JsonUtility.ToJson(sd);
        
        Debug.Log(DateTime.Now.ToString() + jsonData);
        //
        //File.WriteAllText(path, jsonData);
        File.AppendAllText(path, jsonData);
        //if (!File.Exists(path))
        //{
        //    File.WriteAllText(path, jsonData);
        //}
        //else
        //{
        //    //string alldata = File.ReadAllText(path);
        //    //alldata += "\n" + jsonData;
        //    File.AppendText(jsonData);
        //    //File.WriteAllText(path, jsonData);
        //}

    }


    IEnumerator SaveTheCoroutine()
    {
        while (true)
        {
            //Quaternion.Euler() = cam.transform.rotation;
            //SaveData sd = new SaveData();
            //sd.rot_x = cam.transform.rotation.x;
            //sd.rot_y = cam.transform.rotation.y;
            //sd.rot_z = cam.transform.rotation.z;
            //SaveDataJson(sd);
            SaveDataJson(cam.transform.rotation);
            yield return new WaitForSeconds(1f);
            
        }
    }
    IEnumerator JsonSaveCoroutine()
    {
        Debug.Log("StartCoutinge json");
        while (true)
        {
            SaveDataJson(cam.transform.rotation);
            yield return new WaitForSeconds(1f);

        }

    }
}
