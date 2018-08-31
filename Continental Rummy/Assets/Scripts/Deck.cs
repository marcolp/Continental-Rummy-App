using UnityEngine;
using System.Collections.Generic;
using System;

/** This is class of a deck of cards used in the game. */

public class Deck : MonoBehaviour {
	private List<Card> card;
	
	private void Start() { }

    private void Update() { }
	
	public void create() {
		card = new List<Card>();
        foreach(Suit currentSuit in Enum.GetValues(typeof(Suit))) {
            foreach(Value currentValue in Enum.GetValues(typeof(Value))) {
                card.Add(new Card(currentValue, currentSuit));
            }
        }
		
		card.Add(new Card(Value.JOKER1,Suit.ALL));
		card.Add(new Card(Value.JOKER2,Suit.ALL));
	}

    /** Deal the 'top' card (at the end) of this deck. */
    public Card dealCard() {
        if ( card.Count>0 ) {
            Card c = card[card.Count-1];
            card.RemoveAt(card.Count-1);
            return c;
        }
        return null;
    }

    /** Shuffle this deck */
    public void shuffle() {
        List<Card> deck = new List<Card>();
        System.Random rng = new System.Random();
        bool[] used = new bool[card.Count]; //should init to false
        int num;
        while ( !used[num = rng.Next(0,card.Count+1)] ) //min: inclusive, max: exclusive
            deck.Add(card[num]);
    }

    /** Are there any more cards in this deck? */
    public bool isEmpty() {
        return card.Count==0;
    }

    /** SHuffles the cards in the*/
    private void shuffle(List<Deck> toShuffle) {
        List<Card> deck = new List<Card>();
        System.Random rng = new System.Random();
        bool[] used = new bool[toShuffle.Count]; //should init to false
        int num;
        while (!used[num = rng.Next(0,toShuffle.Count+1)]) //min: inclusive, max: exclusive
            deck.Add(card[num]);
    }
}