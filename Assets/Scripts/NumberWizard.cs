using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;
	void Start () {	
		StartGame();	
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			//print ("Up Arrow pressed");
			min = guess;
			NextGuess();
		} else if(Input.GetKeyDown(KeyCode.DownArrow)){
			//print ("Down Arrow pressed");
			max = guess;
			NextGuess();
		} else if(Input.GetKeyDown(KeyCode.Return)){
			print ("I Won!");
			StartGame();
		}	
	}
	
	void StartGame(){
		max = 1000;
		min = 1;
		guess = 500;
		
		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but dont tell me");
		print ("The highest number you can pick is " +max);
		print ("The lowest number you can pick is " +min);
		max = max +1;
		
		print ("Is the number higher or lower than " +guess +"?");
		print ("Press UP Arrow for higher, DOWN Arrow for lower, RETURN for equal.");
	}
	
	void NextGuess(){
		guess = (max + min)/2;
		print ("Is the number higher or lower than " +guess +"?");
		print ("Press UP Arrow for higher, DOWN Arrow for lower, RETURN for equal.");
		
	}
}
