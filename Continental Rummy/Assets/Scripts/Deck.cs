using UnityEngine;
using System.Collections.Generic;
using System;

/** This is class of a deck of cards used in the game. */

public class Deck : MonoBehaviour {
	private List<Card> cardList;
	
	private void Start() { }

    private void Update() { }
	
    public List<Card> getCardList()
    {
        return cardList;
    }
    public Deck()
    {
        cardList = new List<Card>();

        foreach (Suit currentSuit in Enum.GetValues(typeof(Suit)))
        {
            if (currentSuit == Suit.JOKER) continue; //Don't add jokers here
            foreach (Value currentValue in Enum.GetValues(typeof(Value)))
            {
                if ((int)currentValue > 13) continue; //Don't add jokers here
                cardList.Add(new Card(currentValue, currentSuit));
            }
        }

        cardList.Add(new Card(Value.JOKER1, Suit.JOKER));
        cardList.Add(new Card(Value.JOKER2, Suit.JOKER));
    }

	public void create() {
		cardList = new List<Card>();
      
        foreach(Suit currentSuit in Enum.GetValues(typeof(Suit))) {
            if (currentSuit == Suit.JOKER) continue; //Don't add jokers here
            foreach(Value currentValue in Enum.GetValues(typeof(Value))) {
                if ((int)currentValue > 13) continue; //Don't add jokers here
                cardList.Add(new Card(currentValue, currentSuit));
            }
        }

        cardList.Add(new Card(Value.JOKER1,Suit.JOKER));
        cardList.Add(new Card(Value.JOKER2,Suit.JOKER));
	}

    /** Deal the 'top' card (at the end) of this deck. */
    public Card dealCard() {
        if (cardList.Count>0 ) {
            Card c = cardList[cardList.Count-1];
            cardList.RemoveAt(cardList.Count-1);
            return c;
        }
        return null;
    }

    /** Shuffle this deck */
    public void shuffle() {
        List<Card> deck = new List<Card>();
        System.Random rng = new System.Random();
        bool[] used = new bool[cardList.Count]; //should init to false
        int num;
        while ( !used[num = rng.Next(0, cardList.Count+1)] ) //min: inclusive, max: exclusive
            deck.Add(cardList[num]);
    }

    /** Are there any more cards in this deck? */
    public bool isEmpty() {
        return cardList.Count==0;
    }

    /** SHuffles the cards in the*/
    private void shuffle(List<Deck> toShuffle) {
        List<Card> deck = new List<Card>();
        System.Random rng = new System.Random();
        bool[] used = new bool[toShuffle.Count]; //should init to false
        int num;
        while (!used[num = rng.Next(0,toShuffle.Count+1)]) //min: inclusive, max: exclusive
            deck.Add(cardList[num]);
    }

    public string deckToString()
    {
        String deckText = "";
        foreach(Card currentCard in cardList)
        {
            currentCard.printCard();
            deckText += currentCard.cardToString()+"\n";
        }
        return deckText;
    }

    public void printDeck()
    {
        Debug.Log(deckToString());
    }
}