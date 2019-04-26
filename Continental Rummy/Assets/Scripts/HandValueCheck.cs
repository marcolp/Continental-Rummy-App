using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/**
 * Class to detect the value of a set of cards
 */
public class HandValueCheck : MonoBehaviour
{

    //5 points for cards from 2–9
    //10 and face cards count as 10 points
    //aces are 20 points
    //jokers are 50
    public int getScore(List<Card> hand)
    {
        int score = 0;
        foreach ( Card c in hand )
        {
            switch ( c.value )
            {
                case Value.ACE:
                    score += 20;
                    break;
                case Value.TWO:
                case Value.THREE:
                case Value.FOUR:
                case Value.FIVE:
                case Value.SIX:
                case Value.SEVEN:
                case Value.EIGHT:
                case Value.NINE:
                    score += 5;
                    break;
                case Value.TEN:
                case Value.JACK:
                case Value.QUEEN:
                case Value.KING:
                    score += 10;
                    break;
                default:
                    score += 50;
                    break;
            }
        }
        return score;
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

        if (!areSameSuitL(cardSet)) return false; //Cards have different suits

        if ( inOrder(cardSet) )
            return true;

        return false;
    }
    private bool inOrder(List<Card> hand)
    {
        var orderedNoDup = hand.GroupBy(card => card.getValue()).Select(y => y.First());
        var min = orderedNoDup.Min(card => card.getValue());
        var max = orderedNoDup.Max(card => card.getValue());
        var comp = Enumerable.Range((int)min, (int)max - (int)min + 1);
        List<Card> ordered = orderedNoDup.ToList();
        List<int> compL = comp.ToList();
        for (int i = 0; i < ordered.Count; i++)
            if ((int)ordered[i].getValue() != compL[i])
                return false;
        return true;
    }
    private bool areSameSuitL(List<Card> hand)
    {
        var clubs = from card in hand
                    where card.getSuit() == Suit.CLUBS
                    select card;
        var spades = from card in hand
                     where card.getSuit() == Suit.SPADES
                     select card;
        var diamonds = from card in hand
                       where card.getSuit() == Suit.DIAMONDS
                       select card;
        var hearts = from card in hand
                     where card.getSuit() == Suit.HEARTS
                     select card;
        return sameSize(clubs.ToList().Count, spades.ToList().Count, diamonds.ToList().Count, hearts.ToList().Count, hand.Count);
    }
    private bool sameSize(int a, int b, int c, int d, int comp)
    {
        return a == comp || b == comp || c == comp || d == comp;
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

    public bool isTrioL(List<Card> hand)
    {
        var ordered = from card in hand
                      group card by (int)card.getValue() into list
                      let count = list.Count()
                      orderby count descending
                      select new { cValue = list.Key, cCount = count };

        foreach ( var c in ordered )
            if ( c.cCount<=3 )
                return false;
        return true;
    }
}
