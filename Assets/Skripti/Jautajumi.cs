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
    public Text RezulLaiks;
    public Text KursJaut;
    public Text CikIr;

    public GameObject AtbA;
    public GameObject AtbB;
    public GameObject AtbC;
    public GameObject AtbD;

    public GameObject Rezul;

    [HideInInspector]
    public int sk;
    [HideInInspector]
    public int nepareizaAtbilde;
    [HideInInspector]
    public float time;
    [HideInInspector]
    public bool gamePaused = false;

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

    void DisplayTime(float timeToDisplay){
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        RezulLaiks.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    //Pogas
    //----------------------
    public void PogaA()
    {
        if (AtbildeA.text == "User Interface")
        {
            sk++;
        }else if (AtbildeA.text == "Izmantojot RectTransform komponentu")
        {
            sk++;
        }else if (AtbildeA.text == "Izmantojot UI Navigation komponentu")
        {
            sk++;
        }else{
            Debug.Log("Nepareiza Atbilde!");
            nepareizaAtbilde++;
            sk++;
        }
    }
    public void PogaB()
    {
        if (AtbildeB.text == "Image")
        {
            sk++;
        }else if (AtbildeB.text == "Izmantojot AudioSource komponentu"){
            sk++;
        }else if(AtbildeB.text == "Izmantojot Animator komponentu")
        {
            sk++;
        }else{
            Debug.Log("Nepareiza Atbilde!");
            nepareizaAtbilde++;
            sk++;
        }
        
    }
    public void PogaC()
    {
        if (AtbildeC.text == "Panel")
        {
            sk++;
        }else if (AtbildeC.text == "Uzspiežot labo peles pogu Hierarchy logā un izvēloties \"Create UI\" -> \"Canvas\""){
            sk++;
        }else if(AtbildeC.text == "Lai samazinātu atmiņas izmantošanu"){
            sk++;
        }else{
            Debug.Log("Nepareiza Atbilde!");
            nepareizaAtbilde++;
            sk++;
        }
    }
    public void PogaD()
    {
        if(AtbildeD.text == "13"){
            sk++;
        }else if (AtbildeD.text == "Pievienot UI elementu"){
            sk++;
        }else if(AtbildeD.text == "Izmantojot UI elementa \"Screen Space - Overlay\" režīmu")
        {
            sk++;
        }else {
            Debug.Log("Nepareiza Atbilde!");
            nepareizaAtbilde++;
            sk++;
        }
    }
    //----------------------

    void Sk(int sk){

		switch (sk) {
		case 1://A
			jautajums.text = "Ko nozime UI Unity?";
			title.text = "Kas ir UI?";
			AtbildeA.text = "User Interface";   //Pareizā atbilde
			AtbildeB.text = "Interface";
			AtbildeC.text = "Use Interface";
			AtbildeD.text = "User Inside";
			KursJaut.text = sk+"/10";
		break;

		case 2://B,C
            jautajums.text = "Ko var izmantot lai parādītu bildes ar UI elementiem?";
            title.text = "Bildes UI elementi";
            AtbildeA.text = "Button";
            AtbildeB.text = "Image";        //Pareizā atbilde
            AtbildeC.text = "Panel";        //Pareizā atbilde (Manu prāt jo var ielikt bildi viņā)
            AtbildeD.text = "Slider";
            KursJaut.text = sk+"/10";
         break;

        case 3: //D
           jautajums.text = "Cik UI elementi pastāv?";
           title.text = "Cik ir?";
           AtbildeA.text = "5";
           AtbildeB.text = "14";        
           AtbildeC.text = "11";        
           AtbildeD.text = "13";            //Pareizā atbilde
           KursJaut.text = sk + "/10";
         break;

        case 4: //C,D
            jautajums.text = "Kā izveidot jaunu UI Kanvu Unity projektā?";
            title.text = "Kanva";
            AtbildeA.text = " Uzspiežot \"Create Canvas\" pogu Hierarchy logā";
            AtbildeB.text = "Uzspiežot \"Create UI Canvas\" pogu Inspector logā";       
            AtbildeC.text = "Uzspiežot labo peles pogu Hierarchy logā un izvēloties \"Create UI\" -> \"Canvas\"";   //Pareizā atbilde
            AtbildeD.text = "Pievienot UI elementu";        //Arī ir pareizi jo, kad pievieno UI elementu tad kanva automātiski izveidojas
            KursJaut.text = sk + "/10";
        break;

        case 5: //A
            jautajums.text = "Kā var kontrolēt UI elementu pozīciju un izmēru Unity UI sistēmā?";
            title.text = "Elementu pozīcija un izmērs";
            AtbildeA.text = "Izmantojot RectTransform komponentu";      //Pareizā atbilde
            AtbildeB.text = "Izmantojot Button komponentu";
            AtbildeC.text = "Izmantojot Layout Group komponentu";
            AtbildeD.text = "Izmantojot Text komponentu";
            KursJaut.text = sk + "/10";
         break;

        case 6://B
            jautajums.text = "Kādā veidā var pievienot skaņu UI elementam Unity UI sistēmā?";
            title.text = "Skaņās UI elementiem";
            AtbildeA.text = "Izmantojot Sound komponentu";
            AtbildeB.text = "Izmantojot AudioSource komponentu";        //Pareizā atbilde
            AtbildeC.text = "Izmantojot Audio komponentu";
            AtbildeD.text = "Izmantojot AudioClip komponentu";
            KursJaut.text = sk + "/10";
         break;

        case 7://C
            jautajums.text = "Kāpēc ir svarīgi optimizēt UI elementus Unity projektā?";
            title.text = "Optimizācija Unity projektā";
            AtbildeA.text = "Lai uzlabotu grafisko izskatu";
            AtbildeB.text = "Lai ietaupītu enerģiju";
            AtbildeC.text = "Lai samazinātu atmiņas izmantošanu";   //Pareizi
            AtbildeD.text = "Lai padarītu kodu vienkāršāku";
            KursJaut.text = sk + "/10";
         break;

        case 8://B
            jautajums.text = "Kā var izveidot animāciju UI elementam Unity UI sistēmā?";
            title.text = "Animācijas";
            AtbildeA.text = "Izmantojot Motion komponentu";
            AtbildeB.text = "Izmantojot Animator komponentu";       //Pareizā atbilde
            AtbildeC.text = "Izmantojot Animation komponentu";
            AtbildeD.text = "Izmantojot UI Animation komponentu";
            KursJaut.text = sk + "/10";
         break;

        case 9://D
            jautajums.text = "Kā var nodrošināt, lai UI elements paliek fiksēts ekrāna augšpusē pat tad, ja kamera pārvietojas Unity projektā?";
            title.text = "Ekrāna izmērs";
            AtbildeA.text = "Pievienojot UI elementam CanvasGroup komponentu";
            AtbildeB.text = "Pievienojot UI elementam \"Canvas Scaler\" komponentu";
            AtbildeC.text = "Izmantojot UI elementa RectTransform komponentu ar fiksētām pozīcijas vērtībām";
            AtbildeD.text = "Izmantojot UI elementa \"Screen Space - Overlay\" režīmu";     //Pareizā atbilde
            KursJaut.text = sk + "/10";
         break;

        case 10://A
            jautajums.text = "Kā var veikt pāreju no vienas skata uz citu Unity UI sistēmā?";
            title.text = "Skats";
            AtbildeA.text = "Izmantojot UI Navigation komponentu";  //Pareizā atbilde
            AtbildeB.text = "Izmantojot Animation komponentu";
            AtbildeC.text = "Izmantojot Scene komponentu";
            AtbildeD.text = "Izmantojot Input komponentu";
            KursJaut.text = sk + "/10";
         break;

        }

	}

}
