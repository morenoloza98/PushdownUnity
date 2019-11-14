using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject fileRead;
    public GameObject pda;
    public FileReader fileReadScript;
    public PDA pdaScript;

    void Start()
    {
        fileReadScript = fileRead.GetComponent<FileReader>();
        pdaScript = pda.GetComponent<PDA>();
    }

    public void Check(){
        pdaScript.splitFile(fileReadScript.ReadFile());
    }
    

}
