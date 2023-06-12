using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rezultati : MonoBehaviour {
    public Jautajumi objektuSkripts;
    public int cik;
    void Start (){
        objektuSkripts.AtbB.SetActive(true);
        objektuSkripts.AtbC.SetActive(true);
        objektuSkripts.AtbD.SetActive(true);
        objektuSkripts.Rezul.SetActive(false);
    }


    // Update is called once per frame
    void Update () {
        RezultatuLogs();
	}

    void RezultatuLogs ()
    {
    if(objektuSkripts.sk == 10){
            objektuSkripts.gamePaused = true;
            objektuSkripts.AtbA.SetActive(false);
            objektuSkripts.AtbB.SetActive(false);
            objektuSkripts.AtbC.SetActive(false);
            objektuSkripts.AtbD.SetActive(false);
            objektuSkripts.Rezul.SetActive(true);
            objektuSkripts.CikIr.text = 10-objektuSkripts.nepareizaAtbilde+"/10"; 
        }
    }


}
