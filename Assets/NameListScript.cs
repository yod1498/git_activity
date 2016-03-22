using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class NameListScript : MonoBehaviour {

	private List<string> nickName = new List<string>{
		"000 = YOD-YOD1",
		"602 = ",
		"603 = quick",
		"604 = ",
		"613 = ",
		"617 = Toonnn",
		"621 = ",
		"617 = ",
		"621 = Jao",
		"623 = ",
		"625 = kuypon",
		"628 = pandango",
		"633 = tualek",
		"634 = ",
		"636 = Beam",
		"642 = ",
		"646 = ",
		"648 = ",
		"649 = padpattt",
		"654 = ",
		"656 = ",
		"658 = Ratchapong",
		"664 = ",
		"665 = newbieh",
		"667 = ",
		"670 = ",
		"671 = ",
		"679 = tangkwa",
		"687 = Kendo",
		"691 = ",
		"695 = ",
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
