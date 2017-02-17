using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {intro, cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom};
	private States currentState;

	// Use this for initialization
	void Start () {
		//text.text = "Welcome to PRISON - an text adventure game of epic proportions!";
		currentState = States.intro;
	}
	
	// Update is called once per frame
	void Update () {
		print (currentState);
		switch (currentState) {
		case States.intro:
			state_intro ();
			break;
		case States.cell:
			state_cell ();
			break;
		case States.sheets_0:
			state_sheets_0 ();
			break;
		case States.lock_0:
			state_lock_0 ();
			break;
		case States.mirror:
			state_mirror ();
			break;
		case States.cell_mirror:
			state_cell_mirror ();
			break;
		case States.sheets_1:
			state_sheets_1 ();
			break;
		case States.lock_1:
			state_lock_1 ();
			break;
		case States.freedom:
			state_freedom ();
			break;
		}
	}

	void state_intro () {
		text.text = "You wake to the smell of stale urine and fresh feces. The walls are made of cinderblocks and " +
					"covered in moss and lichen. A small mirror hangs on one wall. There's a bed covered in stained sheets. " +
					"You ask yourself, 'Where am I?' You notice the door is simply greasy bars with a large old school lock. Prison cell? " +
					"You have no memory of being arrested, let alone detained. " +
					"Yelling for a guard only brings moans and grunts from what you assume to be other prisoners. " +
					"Where ever you are, you want out. NOW.\n\n" +
					"[S] to view sheets, [M] to view mirror, [L] to view lock";
		if (Input.GetKeyDown (KeyCode.S)) {
			currentState = States.sheets_0;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			currentState = States.mirror;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			currentState = States.lock_0;
		}
	}

	void state_cell () {
		text.text = "The cell hasn't changed much since you last oggled it. Every surface still disgusts you to the point of vommitting. " +
					"The mirror continues to hang on the wall. The bed sheets are still stained beyond recognition. " +
					"The lock is still kicking it old school." +
					"\n\n" +
					"[S] to view sheets, [M] to view mirror, [L] to view lock";
		if (Input.GetKeyDown (KeyCode.S)) {
			currentState = States.sheets_0;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			currentState = States.mirror;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			currentState = States.lock_0;
		}
	}

	void state_sheets_0 () {
		text.text = "The bed is one of the most vile things you've ever laid eyes on. Stained with all manner of fluids and substances, " +
					"the sheets on the bed are stiff. The thought of sleeping on that bed turns your stomach." +
					"\n\n" +
					"[R] to return to oggling your cell walls.";
		if (Input.GetKeyDown (KeyCode.R)) {
			currentState = States.cell;
		}
	}

	void state_lock_0 () {
		text.text = "The lock is like totally old school. Like medieval even. The keys of the keypad don't even have individual LEDs, bruh. " +
					"You stare at the relic of a lock but it doesn't open for you." +
					"\n\n" +
					"[R] to return to oggling your cell walls.";
		if (Input.GetKeyDown (KeyCode.R)) {
			currentState = States.cell;
		}
	}
}
