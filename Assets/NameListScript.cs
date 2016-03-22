using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class NameListScript : MonoBehaviour {

	private List<string> nickName = new List<string>{
		"000 = YOD-YOD1",
		"602 = nok",
		"603 = quick",
		"604 = asma",
		"613 = ",
		"617 = Toonnn",
		"621 = Jao",
		"623 = JackBerserk_",
		"625 = kuypon",
		"628 = pandango",
		"633 = tualek",
		"634 = Mabee",
		"636 = Beam",
		"642 = ",
		"646 = ractoon",
		"648 = ",
		"649 = padpattt",
		"654 = field",
		"656 = ",
		"658 = Ratchapong",
		"664 = ",
		"665 = newbieh",
		"667 = ",
		"670 = apicom",
		"671 = ",
		"679 = tk",
		"687 = Kendo",
		"691 = PoJJa",
		"695 = Kong",
		"563 = ",
		"Amolnat = ",
		"Sangster = ",
		"Fluke = ",
	};
		
	public Text[] colList01;
	public Text[] colList02;
	public Text[] colList03;

	private int counter = 0;

	void Start(){
		foreach (Text colList in colList01) {
			colList.text = nickName [counter];
			counter++;
		}

		foreach (Text colList in colList02) {
			colList.text = nickName [counter];
			counter++;
		}

		foreach (Text colList in colList03) {
			colList.text =nickName [counter];
			counter++;
		}
			
	}
		
}
