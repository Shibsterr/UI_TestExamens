using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jautajumi : MonoBehaviour {
	public Text jautajums;
	public Text AtbildeA;
	public Text AtbildeB;
	public Text AtbildeC;
	public Text AtbildeD;

	private int sk;

	void Start(){
		sk = 1;
	}

	// Update is called once per frame
	void Update () {
		Parbaude();
		Sk (sk);
	}

	int Parbaude(){
		if(sk == 1){
			
		}
	}


	void Sk(int sk){

		switch (sk) {
		case 1:
			jautajums = "Ko nozime UI Unity?";
			AtbildeA = "User Interface";
			AtbildeB = "Interface";
			AtbildeC = "Use Interface";
			AtbildeD = "User Inside";
				
			break;

		}

	}

}
