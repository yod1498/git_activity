﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class NameListScript : MonoBehaviour {

	private List<string> nickName = new List<string>{
		"000 = YOD-YOD",
		"602 = ",
		"603 = ",
		"604 = ",
		"613 = ",
<<<<<<< HEAD
		"617 = Toonnn",
		"621 = ",
=======
		"617 = ",
		"621 = Jao",
>>>>>>> origin/master
		"623 = ",
		"625 = ",
		"628 = panda",
		"633 = ",
		"634 = ",
		"636 = Beam",
		"642 = ",
		"646 = ",
		"648 = ",
		"649 = padpattt",
		"654 = ",
		"656 = ",
		"658 = ",
		"664 = ",
		"665 = ",
		"667 = ",
		"670 = ",
		"671 = ",
		"679 = ",
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
