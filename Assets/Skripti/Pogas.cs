using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Izmanto SceneManagment lai var pārslēgties starp ainām
using UnityEngine.SceneManagement;
public class Pogas : MonoBehaviour {
    public GameObject noteikumi;
    //Pēc kodu palaišanas noteikumu panele ir paslēpta
    void Start()
    {
        noteikumi.SetActive(false);
    }

    //Pēc pogu nospiešanas pārlādē paršreizējo ainu
    public void AtsaktNoJauna() { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //Metode kas ir izlikta uz pogas kas pārmaina ainu uz nākošo vai mūsu gadījumā uz pirmo ainu
    // 1 vietā arī var likt ainas nosaukumu
    public void UzSpeli()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
    //Pēc pogu nospiešanas ieslēdz noteikumu paneli vai parāda to
    public void Noteikumi()
    {
        noteikumi.SetActive(true);
    }
    //Atgriežās atpakaļ no noteikumu paneles paslēpjot to
    public void AtpakalNoNoteikumiem()
    {
        noteikumi.SetActive(false);
    }
    public void Apturet()
    {
        Application.Quit();
    }


}
