using UnityEngine;
using System;
/** This is class for each instance of a Card (name and suit). */

public class Card : MonoBehaviour {
	

	private Value value;
	private Suit suit;
	private bool disposed; //has the card been played?
	private bool inGame; //is the card in the game play?

	private void Start() { }
	
	private void Update() { }
	
	/** Creates this instance of a Card to a name and suit (Constructor)*/
	public Card(Value newValue, Suit newSuit) {
	    value = newValue;
		suit = newSuit;
	}
	
	/** ********** METHODS FOR ACCESSORS ********** */
	public Value getValue() {
		return value;
	}
	
	public Suit getSuit() {
		return suit;
	}
	
	/** ********** METHODS FOR CARD BEHAVIOR IN GAME ********** */
	public void addToGame() {
		inGame = true;
	}
	
	public bool isInGame() {
		return inGame;
	}
	
	public bool isDisposed() {
		return disposed;
	}
	
	public void dispose() {
		disposed = true;
	}
}