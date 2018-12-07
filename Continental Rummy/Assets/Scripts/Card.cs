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
	

    /// <summary>
    /// Creates a random card.
    /// </summary>
    public Card()
    {
        Array values = Enum.GetValues(typeof(Value));
        System.Random randomV = new System.Random();
        Value randomValue = (Value)values.GetValue(randomV.Next(values.Length));

        value = randomValue;


        //Making a joker
        if ((int)randomValue > 13)
        {
            suit = Suit.JOKER;
        }

        else
        {
            Array suits = Enum.GetValues(typeof(Suit));
            System.Random randomS = new System.Random();
            Suit randomSuit = (Suit)values.GetValue(randomS.Next(suits.Length));

            suit = randomSuit;
        }
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

    public string cardToString()
    {
        return "Suit: "+getSuit()+" Value: "+getValue();
    }

    public void printCard()
    {
        Debug.Log(cardToString());
    }
}