using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public GameObject fileReadGO;
    public GameObject pdaGO;
    public FileReader fileReadScript;
    public PDA pdaScript;
    public InputField stringInput;
    public string si;
    

    void Start()
    {
        fileReadScript = fileReadGO.GetComponent<FileReader>();
        pdaScript = pdaGO.GetComponent<PDA>();
    }

    public void Check(){
        
        pdaScript.splitFile(fileReadScript.ReadFile());

        var se= new InputField.SubmitEvent();
        se.AddListener(SubmitString);
        stringInput.onEndEdit = se;

        pdaScript.readStringFromInput(si);
    }

    public void SubmitString(string val){
        si = val;
    }
    

}
