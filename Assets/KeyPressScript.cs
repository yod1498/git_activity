using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KeyPressScript : MonoBehaviour {
	public Text outputText;
	int counter = 0;
	void Update () {
		if (Input.anyKeyDown) {
			counter--;
			outputText.text = "Key Press - : " + counter;
		}
	}
}
