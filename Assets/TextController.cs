using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;

	// Use this for initialization
	void Start () {
		text.text = "Welcome to PRISON - an text adventure game of epic proportions!";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			text.text = "You wake to the smell of stale urine and fresh feces. The walls are made of cinderblocks and " +
						"covered in moss and lichen. A small mirror hangs on one wall. There's a bed covered in stained sheets. " +
						"You ask yourself, 'Where am I?' You notice the door is made up of greasy bars with large old school lock. Prison cell? " +
						"You have no memory of being arrested, let alone detained. " +
						"Yelling for a guard only brings moans and grunts from what you assume to be other prisoners. " +
						"Where ever you are, you want out. NOW.\n\n" +
						"[S] to view sheets, [M] to view mirror, [L] to view lock";
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			text.text = "Return/Enter key pressed!";
		}
	}
}
