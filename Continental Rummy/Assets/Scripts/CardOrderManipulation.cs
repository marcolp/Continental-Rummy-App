using System.Collections.Generic;
using System.Linq;

static class CardOrderManipulation {


    public static List<Card> sortCards(List<Card> cardSet)
    {
        List<Card> setCopy = new List<Card>(cardSet); //MIGHT BE SAME REFERENCE. DONT WANT THAT
        List<Card> SortedList = cardSet.OrderBy(o => o.getValue()).ToList(); //LINQ sorting
        return setCopy;
    }

    public static void shuffle(List<Deck> toShuffle)
    {
        
    }

    /**
     * Method to compare the value of two cards.
     * if card1 is greater than card2 then it returns 1,
     * if card1 is equal to card2 then it returns 0,
     * if card1 is less than card2 then it returns -1.
     * ACE is always smaller in this method.
     */ 
    public static int compareCardsV(Card card1, Card card2)
    {
        int card1Value = (int)card1.getValue();
        int card2Value = (int)card2.getValue();
        int result = -2; 


        if (card1Value > card2Value) result = 1;

        else if (card1Value == card2Value) result = 0;

        else result = -1;

        return result;
    }

}
