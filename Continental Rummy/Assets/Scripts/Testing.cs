using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour {

    private Deck cardDeck;
    public HandValueCheck handChecker;

	// Use this for initialization
	void Start () {
        cardDeck = new Deck();
        //cardDeck.printDeck();
        //Debug.Log("Number of cards: "+cardDeck.getCardList().Count);
        List<Card> newList = new List<Card>();


        Card card1 = new Card();
        newList.Add(card1);

        Card card2 = new Card();
        newList.Add(card2);

        Card card3 = new Card();
        newList.Add(card3);

        Card card4 = new Card();
        newList.Add(card4);

        Card card5 = new Card();
        newList.Add(card5);

        Card card6 = new Card();
        newList.Add(card6);

        //Card card1 = new Card(Value.JOKER1, Suit.JOKER);
        //newList.Add(card1);
        //Card card2 = new Card(Value.JOKER1, Suit.JOKER);
        //newList.Add(card2);
        //Card card3 = new Card(Value.JOKER1, Suit.JOKER);
        //newList.Add(card3);
        //Card card4 = new Card(Value.JOKER1, Suit.JOKER);
        //newList.Add(card4);
        //Card card5 = new Card(Value.JOKER1, Suit.JOKER);
        //newList.Add(card5);
        //Card card6 = new Card(Value.FIVE, Suit.HEARTS);
        //newList.Add(card6);
        foreach (Card tempCard in newList)
        {
            tempCard.printCard();
        }

        Debug.Log("Is this a run? "+handChecker.isRun(newList));
        //CardOrderManipulation.sortCards(newList);
        //foreach(Card tempCard in newList)
        //{
        //    tempCard.printCard();
        //}
    }
	
    

	// Update is called once per frame
	void Update () {
		
	}
}
