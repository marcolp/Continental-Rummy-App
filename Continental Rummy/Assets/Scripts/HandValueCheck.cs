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


     /// <summary>
     /// Method to check if the set of cards is a run.
     /// A run is at least four cards of the same suit
     /// whose value is in ascending order. A run is 
     /// made with 4 of more cards. Relies on the order
     /// that the cards were received in.
     /// </summary>
     /// <returns><c>true</c>, if run was ised, <c>false</c> otherwise.</returns>
     /// <param name="cardSet">Card set.</param>
    public bool IsRun(List<Card> cardSet)
    {
        if (cardSet.Count < 4) return false; //Not enough cards to be a run

        if (!AreSameSuit(cardSet)) return false; //Cards have different suits

        //Traverse all cards except the last one
        for(int i = 0; i < cardSet.Count-1; i++)
        {
            Value currentCardValue = cardSet[i].getValue();
            Value nextCardValue = cardSet[i+1].getValue();

            //If the current card is a joker
            if(currentCardValue == Value.JOKER1 || currentCardValue == Value.JOKER2)
            {
                //If a joker is the first index, then the order of the next
                //card is always correct
                if(i == 0)
                {
                    continue;
                }

                //Joker isn't the first card
                else
                {
                    /** 
                     * Check that the next card is part of the run.
                     * Make sure that the next card is 2 more than the
                     * previous one. For example: (TWO, THREE, JOKER, FIVE)
                     * when the joker is reached it will check that five is 
                     * two more than THREE. This is to prevent something like:
                     * (TWO, THREE, JOKER, SIX) to be correct if we were to 
                     * just check that the joker is one less than the next.                    
                    */                   
                    Value previousCardValue = cardSet[i - 1].getValue();
                    if (previousCardValue + 2 == nextCardValue || nextCardValue == Value.JOKER1 || nextCardValue == Value.JOKER2)
                    {
                        continue;
                    }

                    //Not a run
                    else
                    {
                        return false;
                    }
                }
            }

            //Card is not a joker
            else
            {
                //Check that the next card is one value greater than 
                //the current card or that it's a joker.
                if (currentCardValue + 1 == nextCardValue || nextCardValue == Value.JOKER1 || nextCardValue == Value.JOKER2)
                {
                    continue;
                }

                //Not a run
                else
                {
                    return false;
                }
            } 
        }

        return true;
    }


    /// <summary>
    /// Method to check if the set of cards are the same suit.
    /// </summary>
    /// <returns><c>true</c> if same suit <c>false</c> otherwise.</returns>
    /// <param name="cardSet">Card set.</param>
    public bool AreSameSuit(List<Card> cardSet)
    {


        Suit tempSuit = cardSet[0].getSuit();

        //Ceck that all cards have the same suit
        foreach (Card currentCard in cardSet)
        {
            if (tempSuit == currentCard.getSuit() || Suit.JOKER == currentCard.getSuit())
            {
                continue;
            }


            //If any of the cards is a different suit 
            //then they are not the same suit
            else
                return false;
        }

        //If we compared all the cards that means they are the same!
        return true;
    }



    /// <summary>
    /// Method to check if a set of cards is a trio.
    /// A trio is made with at least 3 cards.
    /// NOTE that despite it being called a trio, there could
    /// be more than three. As long as all have the same value
    /// it is considered a trio
    /// </summary>
    /// <returns><c>true</c> if trio <c>false</c> otherwise.</returns>
    /// <param name="cardSet">Card set.</param>
    public bool IsTrio(List<Card> cardSet)
    {
        if (cardSet.Count < 3) return false; //Not enough cards to be a trio

        Value tempValue = cardSet[0].getValue();

        foreach(Card currentCard in cardSet)
        {
            if(tempValue == currentCard.getValue() || Value.JOKER1 == currentCard.getValue() || Value.JOKER2 == currentCard.getValue())
            {
                continue;
            }

            //If any of the cards is a different value then it is not a trio
            else
            {
                return false;
            }
        }

        //If we compared all the cards that means they are the same!
        return true;
    }
}
