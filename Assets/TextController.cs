using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {
		intro, cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, doorway, corridor_0, corridor_1, corridor_2, corridor_3,
		stairs_0, stairs_1, stairs_2, floor, closet_door, in_closet_0, in_closet_1, freedom
		};
	private States currentState;

	// Use this for initialization
	void Start () {
		currentState = States.intro;
	}
	
	// Update is called once per frame
	void Update () {
		print (currentState);
		switch (currentState) {
		case States.intro:
			intro ();
			break;
		case States.cell:
			cell ();
			break;
		case States.sheets_0:
			sheets_0 ();
			break;
		case States.lock_0:
			lock_0 ();
			break;
		case States.mirror:
			mirror ();
			break;
		case States.cell_mirror:
			cell_mirror ();
			break;
		case States.sheets_1:
			sheets_1 ();
			break;
		case States.lock_1:
			lock_1 ();
			break;
		case States.doorway:
			doorway ();
			break;
		case States.corridor_0:
			corridor_0 ();
			break;
		case States.stairs_0:
			stairs_0 ();
			break;
		case States.closet_door:
			closet_door ();
			break;
		case States.floor:
			floor ();
			break;
		case States.corridor_1:
			corridor_1 ();
			break;
		case States.stairs_1:
			stairs_1 ();
			break;
		case States.stairs_2:
			stairs_2 ();
			break;
		case States.in_closet_0:
			in_closet_0 ();
			break;
		case States.in_closet_1:
			in_closet_1 ();
			break;
		case States.corridor_2:
			corridor_2 ();
			break;
		case States.corridor_3:
			corridor_3 ();
			break;
		case States.freedom:
			freedom ();
			break;
		}
	}

	#region State Functions
	
	void intro () {
		text.text = "Welcome to PRISON - a text adventure game of epic proportions!\n\n" +
					"You wake to the smell of stale urine and fresh feces. The walls are made of cinderblocks and " +
					"covered in moss and lichen. A small mirror hangs on one wall. There's a bed covered in stained sheets. " +
					"You ask yourself, 'Where am I?' You notice the door is simply greasy bars with a large old school lock. Prison cell? " +
					"You have no memory of being arrested, let alone detained. " +
					"Yelling for a guard only brings moans and grunts from what you assume to be other prisoners. " +
					"Where ever you are, you want out. NOW.\n\n" +
					"Press [S] to get cozy with the sheets, [M] to peer into the mirror, [L] to do a flipkick to an ollie at the lock";
		if (Input.GetKeyDown (KeyCode.S)) {
			currentState = States.sheets_0;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			currentState = States.mirror;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			currentState = States.lock_0;
		}
	}

	void cell () {
		text.text = "The cell hasn't changed much since you last oggled it. Every surface still disgusts you to the point of vomitting. " +
					"The mirror continues to hang on the wall. The bed sheets are still stained beyond recognition. " +
					"The lock is still kicking it old school." +
					"\n\n" +
					"Press [S] to snuggle with the sheets, [M] to reflect on the mirror, [L] to inspect that totally awesome lock";
		if (Input.GetKeyDown (KeyCode.S)) {
			currentState = States.sheets_0;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			currentState = States.mirror;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			currentState = States.lock_0;
		}
	}

	void sheets_0 () {
		text.text = "The bed is one of the most vile things you've ever laid eyes on. Stained with all manner of fluids and substances, " +
					"the sheets on the bed are stiff. The thought of sleeping on that bed turns your stomach." +
					"\n\n" +
					"Press [R] to return to oggling your cell walls.";
		if (Input.GetKeyDown (KeyCode.R)) {
			currentState = States.cell;
		}
	}

	void lock_0 () {
		text.text = "The lock is like totally old school. Like medieval even. The keys of the keypad don't even have individual LEDs, bruh. " +
					"You stare at the relic of a lock but it doesn't open for you." +
					"\n\n" +
					"Press [R] to return to oggling your cell walls.";
		if (Input.GetKeyDown (KeyCode.R)) {
			currentState = States.cell;
		}
	}
	
	void mirror () {
		text.text = "You examine the mirror from every angle. Your face and clothes appear to be similar to the cell walls and the bed sheets. " +
					"You caress the mirror with your oily, grubby hands. It swings back and forth. Mind. Blown." +
					"\n\n" +
					"Press [T] to attempt to tear the mirror from the wall, [R] to return to oggling your cell walls.";
		if (Input.GetKeyDown (KeyCode.R)) {
			currentState = States.cell;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			currentState = States.cell_mirror;
		}
	}
	
	void cell_mirror () {
		text.text = "The cell seems different since you last oggled it. It feels.... It feels... more escape-y. " +
					"Some things haven't changed. The walls are putrid. The bed sheets are still *shudder*. The lock is still totally radical." +
					"\n\n" +
					"Press [S] to look at the sheets, [L] to check out that killer lock";
		if (Input.GetKeyDown (KeyCode.S)) {
			currentState = States.sheets_1;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			currentState = States.lock_1;
		}
	}
	
	void sheets_1 () {
		text.text = "Now that you have a mirror, seeing double of the sheets doesn't make them any more appealing. You can't figure out why." +
					"\n\n" +
					"Press [R] to return to oggling your cell walls in stereo!";
		if (Input.GetKeyDown (KeyCode.R)) {
			currentState = States.cell_mirror;
		}
	}
	
	void lock_1 () {
		text.text = "The lock is still freaking cool, man. You decide to use the mirror to check out the lock from all angles so you can take it ALL in. " +
					"You notice that 4 of the buttons on the lock have had the number worn off. You think. You think HARD." +
					"\n\n" +
					"Press [R] to return to oggling your cell walls which you realize are more interesting than the lock, [P] to press the worn buttons " +
					"to attempt an escape.";
		if (Input.GetKeyDown (KeyCode.R)) {
			currentState = States.cell_mirror;
		} else if (Input.GetKeyDown (KeyCode.P)) {
			currentState = States.doorway;
		}
	}
	
	void doorway () {
		text.text = "You randomly press the worn buttons. The lock clicks. You've done it! You are free! You quickly return the mirror to the wall. " +
					"You have a decision to make: escape this horrible place or lock yourself back in the cell to continue your oggling." +
					"\n\n" +
					"Press [L] to lock yourself back into the cell, [C] to step out into the corridor";
		if (Input.GetKeyDown (KeyCode.L)) {
			currentState = States.cell;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			currentState = States.corridor_0;
		}
	}
	
	void corridor_0 () {
		text.text = "The corridor looks like it's straight out of a disco club. The walls glitter, a disco ball hangs from the ceiling, " +
					"multi-coloured laser lights shoot in all directions and the floor looks like highly polished linoleum. " +
					"There's a stairway labelled \"Escape This Way\" leading to what appears to be daylight. There's a closet here that says " +
					"\"Clothes To Boogie In\". You get dizzy with all the wonderful things to oggle." +
					"\n\n" +
					"Press [S] to take the stairs to freedom, [F] to inspect the floor for blemishes, [C] to attempt to open the closet to get to those " +
					"killer threads";
		if (Input.GetKeyDown (KeyCode.S)) {
			currentState = States.stairs_0;
		} else if (Input.GetKeyDown (KeyCode.F)) {
			currentState = States.floor;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			currentState = States.closet_door;
		}
	}
	
	void stairs_0 () {
		text.text = "You peer up the stairs. At the top of the stairs you can see a guard. He looks to be 500 lbs, 8 feet tall and, with hands " +
					"the size of excavator buckets. He is also armed with an RPG. You want to tell him the RPG is a poor choice for close quarters combat " +
					"but, after playing \"Eeny, Meeny, Miny, Moe\", you decide to not mention it at this juncture." +
					"\n\n" +
					"Press [R] to return to the corridor";
		if (Input.GetKeyDown (KeyCode.R)) {
			currentState = States.corridor_0;
		}
	}
	
	void closet_door () {
		text.text = "The door is locked." +
					"\n\n" +
					"Press [R] to return to the corridor";
		if (Input.GetKeyDown (KeyCode.R)) {
			currentState = States.corridor_0;
		}
	}
	
	void floor () {
		text.text = "Your eyes dart about the oh so shiny linoleum as you try to fill your soul with pure, unrefracted light. " +
					"Every square centimetre is absolutely pristine which causes your heart to expand three sizes larger. " +
					"You dance about the floor, praising it for reflecting soul filling light into your very essence. " +
					"This feeling of pure joy washing over your entire being suddenly ends when you notice something out of place: a hairpin. " +
					"The light your soul had collected drains from your body onto the floor from whence it came." +
					"\n\n" +
					"Press [H] to remove the ghastly blemish (the hairpin) from the heavenly plane (the floor), [R] to return to the corridor";
		if (Input.GetKeyDown (KeyCode.H)) {
			currentState = States.corridor_1;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			currentState = States.corridor_0;
		}
	}
	
	void corridor_1 () {
		text.text = "The corridor feels much cleaner now that you've picked up the blasphemous hairpin. " +
					"The floor and walls reflect light and love directly into your soul. The disco ball spins to the rythmn of your heart beat. " +
					"It feels like the multi-colour laser lights are piercing the fog of your mind and raising you to a higher plane of existence and " +
					"ever closer to complete enlightenment. The stairs to freedom continue to beckon you. Your soul tells you that the closet labelled " +
					"\"Clothes To Boogie In\" may hold the key to life and the universe itself." +
					"\n\n" +
					"Press [S] to answer the call of the stairs, [P] to pick the lock with the hairpin so you may entire the chamber of light (the closet)";
		if (Input.GetKeyDown (KeyCode.S)) {
			currentState = States.stairs_1;
		} else if (Input.GetKeyDown (KeyCode.P)) {
			currentState = States.in_closet_0;
		}
	}

	void stairs_1 () {
		text.text = "You look up the stairwell. The guard is still there but now he's polishing his guns. Well, more like cannons. 50mm cannons. " +
					"You've come to the conclusion that the sign above the entrance to the stairwell is either a joke or placed over the wrong stairwell. " +
					"Damn government workers...." +
					"\n\n" +
					"Press [R] to return to the corridor";
		if (Input.GetKeyDown (KeyCode.R)) {
			currentState = States.corridor_1;
		}
	}
	
	void in_closet_0 () {
		text.text = "With the door kicked in (damn faulty hairpin), you see several open boxes labelled \"Clothes To Boogie In\". " +
					"Most of the clothes are polyester leisure suits and bellbottoms. Everything has sequines except for a skintight unitard with a tag " +
					"that reads \"Invisibilty Unitard\". You strip naked in anticipation." +
					"\n\n" +
					"Press [U] to put on the stealth unitard and step out into the corridor, " +
					"[R] to put your regular clothes on (boring) and return to the corridor";
		if (Input.GetKeyDown (KeyCode.U)) {
			currentState = States.corridor_3;
		}		
		if (Input.GetKeyDown (KeyCode.R)) {
			currentState = States.corridor_2;
		}
	}
	
	void in_closet_1 () {
		text.text = "You return to closet with all the open boxes filled with smelly boogie clothes. You strip naked so it's easier to think. " +
					"There are two options: become the embodiment of pure sexy by putting on the stealth unitard OR put your street clothes on and " +
					"go out into the corridor as boring you." +
					"\n\n" +
					"Press [S] to put on the sexy stealth unitard and step out into the corridor, " +
					"[R] to put on your regular duds, return to the corridor, and impress noone";
		if (Input.GetKeyDown (KeyCode.S)) {
			currentState = States.corridor_3;
		}		
		if (Input.GetKeyDown (KeyCode.R)) {
			currentState = States.corridor_2;
		}
	}
	
	void corridor_2 () {
		text.text = "The corridor boogie-ified light show dances across your skin and clothes. Your enlightenment meter continues to tick upward. " +
					"You can attempt your escape again up the stairs or you can return to the Chamber of Light (aka the closet)." +
					"\n\n" +
					"Press [S] to attempt escaping up the stairs, [C] to return to the Chamber of Light (aka the closet)";
		if (Input.GetKeyDown (KeyCode.S)) {
			currentState = States.stairs_2;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			currentState = States.in_closet_1;
		}
	}
	
	void stairs_2 () {
		text.text = "You look up the stairwell again. The guard now appears to be playing a game of 3 vs 3 basketball using, you assume, a fellow prisoner's " +
					"head. The guard and all the other players are also holding knives. It still doesn't look like an escape would go all that well right now." +
					"\n\n" +
					"Press [R] to return to the corridor";
		if (Input.GetKeyDown (KeyCode.R)) {
			currentState = States.corridor_2;
		}
	}
	
	void corridor_3 () {
		text.text = "With the unitard covering every square centimetre of your sumptuous body, you feel like Predator minus the heat vision. " +
					"Being invisible (less your head, of course), you feel a surge of power in every fibre of your body. " +
					"The laser light show passes though your chest and legs. You no longer glitter and glow. You are but a window into the universe. " +
					"Silent and invisible " +
					"(except your head), you swear you can feel neutrinos passing through you on their journey into the unknown." + 
					"\n\n" +
					"You are a god." +
					"\n\n" +
					"The stairs to \"freedom\" are still calling you to ascend to your rightful place in the heavens. The unitard is a litle ichy so there's " +
					"always the option to return to the closet." +
					"\n\n" +
					"Press [S] to ascend, [C] to chicken out and return to the closet";
		if (Input.GetKeyDown (KeyCode.S)) {
			currentState = States.freedom;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			currentState = States.in_closet_1;
		}
	}
	
	void freedom () {
		text.text = "You look up the stairs to find the guard playing Pokemon Go on his smartphone. Now's your chance! You sprint up the stairs at your top " +
					"speed of 3 km/h. You whiz by the guard, your non-invisible head bobbing up and down in front of him. You continue to run towards the " +
					"front gate. Using your l33t parkour skills, you climb the walls and gate like Spider-Man and jump over the gate. " +
					"You run and run and run!" + 
					"\n\n" +
					"YOU ARE FREE!!!!!" +
					"\n\n" +
					"Press [P] to imprison yourself and play again, [Esc] to quit";
		if (Input.GetKeyDown (KeyCode.P)) {
			currentState = States.cell;
		} else if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}
	
	#endregion	
}