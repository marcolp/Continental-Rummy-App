using System.Collections.Generic;

static class CardOrderManipulation {


    public static List<Card> sortCards(List<Card> cardSet)
    {
        List<Card> setCopy = new List<Card>(cardSet); //MIGHT BE SAME REFERENCE. DONT WANT THAT



        return setCopy;
    }

    /**
     * Method to compare the value of two cards.
     * if card1 is greater than card2 then it returns 1,
     * if card1 is equal to card2 then it returns 0,
     * if card1 is less than card2 then it returns -1.
     * if card1 or card2 is an ACE, then the ace is always larger
     * UNLESS we are trying to make a run with ACE, two, etc.
     */ 
    public static int compareCardsV(Card card1, Card card2)
    {
        int card1Value = (int)card1.getValue();
        int card2Value = (int)card2.getValue();
        int result = -2; 

        //If the cards being compared are aces, then have them be the highest value
        if(card1.getValue() == Value.ACE) card1Value = 14;
        if(card2.getValue() == Value.ACE) card2Value = 14;
        


        if (card1Value > card2Value) result = 1;

        else if (card1Value == card2Value) result = 0;

        else result = -1;
        return result;
    }

}
