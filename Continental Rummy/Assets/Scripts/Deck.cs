using UnityEngine;
using System.Collections.Generic;
using System;
/** This is class of a deck of cards used in the game. */

public class Deck : MonoBehaviour
{
	private List<Card> card;
	
	private void Start()
    {
    }

    private void Update()
    {
    }
	
	public void create()
    {
		card = new List<Card>();
        foreach(Suit currentSuit in Enum.GetValues(typeof(Suit)))
        {
            foreach(Value currentValue in Enum.GetValues(typeof(Value)))
            {
                card.Add(new Card(currentValue, currentSuit));
            }
        }
		
		card.Add(new Card(Value.JOKER1,Suit.ALL));
		card.Add(new Card(Value.JOKER2,Suit.ALL));
	}
}