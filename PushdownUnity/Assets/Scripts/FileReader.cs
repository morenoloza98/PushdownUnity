using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileReader : MonoBehaviour
{
    string[] lines = new string[10];

    public void ReadFile()
    {
        lines = System.IO.File.ReadAllLines("Assets/TextFiles/test1.txt");
        for (int i = 0; i < lines.Length; i++)
        {
            Debug.Log(lines[i]);
        }
    }


}
