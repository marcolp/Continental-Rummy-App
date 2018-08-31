using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Class to detect the value of a set of cards
 */
public class HandValueCheck : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /**
     * Method to check if the set of cards is a run.
     * A run is at least four cards of the same suit
     * whose value is in ascending order. A run is 
     * made with 4 of more cards.
     */
    public bool isRun(List<Card> cardSet)
    {
        if (cardSet.Count < 4) return false; //Not enough cards to be a run

        if (!areSameSuit(cardSet)) return false; //Cards have different suits



        return false;
    }

    /**
     * Method to check if the set of cards are the same suit.
     */
    public bool areSameSuit(List<Card> cardSet)
    {
        Suit tempSuit = 0;
        int counter = 0;

        //Ceck that all cards have the same suit
        foreach (Card currentCard in cardSet)
        {
            //Take the first card and compare it to the rest
            if (counter == 0)
            {
                tempSuit = currentCard.getSuit();
                continue;
            }

            else
            {
                
                if (tempSuit == currentCard.getSuit())
                {
                    continue;
                }

                //If any of the cards is a different suit then it is not a trio
                else
                {
                    return false;
                }
            }
        }

        //If we compared all the cards that means they are the same!
        return true;
    }

    /**
     * Method to check if a set of cards is a trio.
     * A trio is made with at least 3 cards.
     * NOTE that despite it being called a trio, there could
     * be more than three. As long as all have the same value
     * it is considered a trio
     */
    public bool isTrio(List<Card> cardSet)
    {
        if (cardSet.Count < 3) return false; //Not enough cards to be a tio

        Value tempValue = 0;
        int counter = 0;

        foreach(Card currentCard in cardSet)
        {
            //Take the first card and compare it to the rest
            if (counter == 0)
            {
                tempValue = currentCard.getValue();
                continue;
            }

            else
            {
               
                if(tempValue == currentCard.getValue())
                {
                    continue;
                }

                //If any of the cards is a different value then it is not a trio
                else
                {
                    return false;
                }
            }
        }

        //If we compared all the cards that means they are the same!
        return true;
    }
}
