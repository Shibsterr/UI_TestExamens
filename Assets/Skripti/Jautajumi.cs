using UnityEngine;
using UnityEngine.UI;

public class Jautajumi : MonoBehaviour {
	public Text jautajums;
    public Text title;
    public Text AtbildeA;
	public Text AtbildeB;
	public Text AtbildeC;
	public Text AtbildeD;
	public Text timeText;
	public Text KursJaut;

	private int sk;
    private int nepareizaAtbilde;
    [HideInInspector]
    public float time;

    private bool gamePaused = false;

    void Start(){
		time = 0;
		sk = 1;
	}

	// Update is called once per frame
	void Update () {
		Sk (sk);
        if (!gamePaused)
        {
            time += Time.deltaTime;
            DisplayTime(time);
        }

    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

	public void PogaA(){
		if(AtbildeA.text == "User Interface"){
			sk++;
		}else if (AtbildeA.text == "Button") {
			Debug.Log("Nepareiza Atbilde!");
            nepareizaAtbilde--;
            sk++;

        }
	}

    public void PogaB()
    {
        if (AtbildeB.text == "Interface")
        {
            Debug.Log("Nepareiza Atbilde!");
            nepareizaAtbilde--;
            sk++;
        }
        else if (AtbildeB.text == "Image")
        {
            sk++;
        }
    }

    public void PogaC()
    {
        if (AtbildeC.text == "Use Interface")
        {
            Debug.Log("Nepareiza Atbilde!");
            nepareizaAtbilde--;
            sk++;
        }
        else if (AtbildeC.text == "Panel")
        {
            sk++;
        }
    }


    public void PogaD()
    {
        if (AtbildeD.text == "User Inside")
        {
            Debug.Log("Nepareiza Atbilde!");
            nepareizaAtbilde--;
            sk++;
        }
        else if (AtbildeD.text == "Slider")
        {
            Debug.Log("Nepareiza Atbilde!");
            nepareizaAtbilde--;
            sk++;
        }
    }


    void Sk(int sk){

		switch (sk) {
		case 1:
			jautajums.text = "Ko nozime UI Unity?";
			title.text = "Kas ir UI?";
			AtbildeA.text = "User Interface";   //Pareizā atbilde
			AtbildeB.text = "Interface";
			AtbildeC.text = "Use Interface";
			AtbildeD.text = "User Inside";
			KursJaut.text = sk+"/10";
		break;

		case 2:
            jautajums.text = "Kā var parādīt bildes ar UI elementiem?";
            title.text = "Bildes UI elementi";
            AtbildeA.text = "Button";
            AtbildeB.text = "Image";        //Pareizā atbilde
            AtbildeC.text = "Panel";        //Pareizā atbilde (Manu prāt jo var ielikt bildi viņā)
            AtbildeD.text = "Slider";
            KursJaut.text = sk+"/10";
         break;

        case 3:
           jautajums.text = "";
           title.text = "";
           AtbildeA.text = "";
           AtbildeB.text = "";        
           AtbildeC.text = "";        
           AtbildeD.text = "";
           KursJaut.text = sk + "/10";
         break;

        case 4:
            jautajums.text = "";
            title.text = "";
            AtbildeA.text = "";
            AtbildeB.text = "";
            AtbildeC.text = "";
            AtbildeD.text = "";
            KursJaut.text = sk + "/10";
        break;

        case 5:
            jautajums.text = "";
            title.text = "";
            AtbildeA.text = "";
            AtbildeB.text = "";
            AtbildeC.text = "";
            AtbildeD.text = "";
            KursJaut.text = sk + "/10";
         break;


        case 6:
            jautajums.text = "";
            title.text = "";
            AtbildeA.text = "";
            AtbildeB.text = "";
            AtbildeC.text = "";
            AtbildeD.text = "";
            KursJaut.text = sk + "/10";
         break;

        case 7:
            jautajums.text = "";
            title.text = "";
            AtbildeA.text = "";
            AtbildeB.text = "";
            AtbildeC.text = "";
            AtbildeD.text = "";
            KursJaut.text = sk + "/10";
         break;

        case 8:
            jautajums.text = "";
            title.text = "";
            AtbildeA.text = "";
            AtbildeB.text = "";
            AtbildeC.text = "";
            AtbildeD.text = "";
            KursJaut.text = sk + "/10";
         break;

        case 9:
            jautajums.text = "";
            title.text = "";
            AtbildeA.text = "";
            AtbildeB.text = "";
            AtbildeC.text = "";
            AtbildeD.text = "";
            KursJaut.text = sk + "/10";
         break;


        case 10:
            jautajums.text = "";
            title.text = "";
            AtbildeA.text = "";
            AtbildeB.text = "";
            AtbildeC.text = "";
            AtbildeD.text = "";
            KursJaut.text = sk + "/10";
         break;

        }

	}

}
