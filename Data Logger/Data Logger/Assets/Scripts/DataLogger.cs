/*
Name: Matthew Parnham
Student ID#: 2287511
Chapman email: parnham@chapman.edu
Course Number and Section: CPSC236-02
Assignment: Data Logger
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class DataLogger : MonoBehaviour
{

    private string fileName = "testLog";
    private string path = "Assets/Logs/";
    private string filePath;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello, World!");
        WriteString();
    }

   public void WriteString()
    {
        filePath = path + fileName + ".txt";
        StreamWriter writer = new StreamWriter(filePath, true);
        writer.WriteLine("Hi Derek");
        writer.Close();

        AssetDatabase.ImportAsset(filePath);
        Resources.Load(filePath);
    }
}
