using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardCreator : MonoBehaviour {

    public GameObject cardPrefab;
    public GameObject container;

    public Sprite AceH;
    public Sprite TwoH;
    public Sprite ThreeH;
    public Sprite FourH;
    public Sprite FiveH;
    public Sprite SixH;
    public Sprite SevenH;
    public Sprite EightH;
    public Sprite NineH;
    public Sprite TenH;
    public Sprite JackH;
    public Sprite QueenH;
    public Sprite KingH;

    public Sprite AceD;
    public Sprite TwoD;
    public Sprite ThreeD;
    public Sprite FourD;
    public Sprite FiveD;
    public Sprite SixD;
    public Sprite SevenD;
    public Sprite EightD;
    public Sprite NineD;
    public Sprite TenD;
    public Sprite JackD;
    public Sprite QueenD;
    public Sprite KingD;

    public Sprite AceS;
    public Sprite TwoS;
    public Sprite ThreeS;
    public Sprite FourS;
    public Sprite FiveS;
    public Sprite SixS;
    public Sprite SevenS;
    public Sprite EightS;
    public Sprite NineS;
    public Sprite TenS;
    public Sprite JackS;
    public Sprite QueenS;
    public Sprite KingS;

    public Sprite AceC;
    public Sprite TwoC;
    public Sprite ThreeC;
    public Sprite FourC;
    public Sprite FiveC;
    public Sprite SixC;
    public Sprite SevenC;
    public Sprite EightC;
    public Sprite NineC;
    public Sprite TenC;
    public Sprite JackC;
    public Sprite QueenC;
    public Sprite KingC;

    public Sprite Joker1;
    public Sprite Joker2;

    public Sprite backside;


    private static System.Random randomV = new System.Random();

    // Use this for initialization
    void Start () {
        StartCoroutine(DealHand());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator DealHand()
    {
        for (int i = 0; i < 5; i++)
        {
            InstantiateRandomCard();
            yield return new WaitForSeconds(1f);
        }
    }
    public void InstantiateRandomCard()
    {
        Array values = Enum.GetValues(typeof(Value));
        Value randomValue = (Value)values.GetValue(randomV.Next(values.Length));
        Suit suit;
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

        InstantiateCard(suit, randomValue);

    }

    public void InstantiateCard(Suit cardSuit, Value cardValue)
    {

        GameObject newCard = Instantiate(cardPrefab, container.transform);

        newCard.GetComponent<Card>().value = cardValue;
        newCard.GetComponent<Card>().suit = cardSuit;

        if (cardSuit == Suit.CLUBS)
        {
            switch(cardValue)
            {
                case Value.ACE:
                    newCard.GetComponent<Image>().sprite = AceC;
                    break;
                case Value.TWO:
                    newCard.GetComponent<Image>().sprite = TwoC;
                    break;
                case Value.THREE:
                    newCard.GetComponent<Image>().sprite = ThreeC;
                    break;
                case Value.FOUR:
                    newCard.GetComponent<Image>().sprite = FourC;
                    break;
                case Value.FIVE:
                    newCard.GetComponent<Image>().sprite = FiveC;
                    break;
                case Value.SIX:
                    newCard.GetComponent<Image>().sprite = SixC;
                    break;
                case Value.SEVEN:
                    newCard.GetComponent<Image>().sprite = SevenC;
                    break;
                case Value.EIGHT:
                    newCard.GetComponent<Image>().sprite = EightC;
                    break;
                case Value.NINE:
                    newCard.GetComponent<Image>().sprite = NineC;
                    break;
                case Value.TEN:
                    newCard.GetComponent<Image>().sprite = TenC;
                    break;
                case Value.JACK:
                    newCard.GetComponent<Image>().sprite = JackC;
                    break;
                case Value.QUEEN:
                    newCard.GetComponent<Image>().sprite = QueenC;
                    break;
                case Value.KING:
                    newCard.GetComponent<Image>().sprite = KingC;
                    break;
                default:
                    newCard.GetComponent<Image>().sprite = backside;
                    break;
            }
        }

        else if(cardSuit == Suit.SPADES)
        {
            switch (cardValue)
            {
                case Value.ACE:
                    newCard.GetComponent<Image>().sprite = AceS;
                    break;
                case Value.TWO:
                    newCard.GetComponent<Image>().sprite = TwoS;
                    break;
                case Value.THREE:
                    newCard.GetComponent<Image>().sprite = ThreeS;
                    break;
                case Value.FOUR:
                    newCard.GetComponent<Image>().sprite = FourS;
                    break;
                case Value.FIVE:
                    newCard.GetComponent<Image>().sprite = FiveS;
                    break;
                case Value.SIX:
                    newCard.GetComponent<Image>().sprite = SixS;
                    break;
                case Value.SEVEN:
                    newCard.GetComponent<Image>().sprite = SevenS;
                    break;
                case Value.EIGHT:
                    newCard.GetComponent<Image>().sprite = EightS;
                    break;
                case Value.NINE:
                    newCard.GetComponent<Image>().sprite = NineS;
                    break;
                case Value.TEN:
                    newCard.GetComponent<Image>().sprite = TenS;
                    break;
                case Value.JACK:
                    newCard.GetComponent<Image>().sprite = JackS;
                    break;
                case Value.QUEEN:
                    newCard.GetComponent<Image>().sprite = QueenS;
                    break;
                case Value.KING:
                    newCard.GetComponent<Image>().sprite = KingS;
                    break;
                default:
                    newCard.GetComponent<Image>().sprite = backside;
                    break;
            }
        }

        else if(cardSuit == Suit.DIAMONDS)
        {
            switch (cardValue)
            {
                case Value.ACE:
                    newCard.GetComponent<Image>().sprite = AceD;
                    break;
                case Value.TWO:
                    newCard.GetComponent<Image>().sprite = TwoD;
                    break;
                case Value.THREE:
                    newCard.GetComponent<Image>().sprite = ThreeD;
                    break;
                case Value.FOUR:
                    newCard.GetComponent<Image>().sprite = FourD;
                    break;
                case Value.FIVE:
                    newCard.GetComponent<Image>().sprite = FiveD;
                    break;
                case Value.SIX:
                    newCard.GetComponent<Image>().sprite = SixD;
                    break;
                case Value.SEVEN:
                    newCard.GetComponent<Image>().sprite = SevenD;
                    break;
                case Value.EIGHT:
                    newCard.GetComponent<Image>().sprite = EightD;
                    break;
                case Value.NINE:
                    newCard.GetComponent<Image>().sprite = NineD;
                    break;
                case Value.TEN:
                    newCard.GetComponent<Image>().sprite = TenD;
                    break;
                case Value.JACK:
                    newCard.GetComponent<Image>().sprite = JackD;
                    break;
                case Value.QUEEN:
                    newCard.GetComponent<Image>().sprite = QueenD;
                    break;
                case Value.KING:
                    newCard.GetComponent<Image>().sprite = KingD;
                    break;
                default:
                    newCard.GetComponent<Image>().sprite = backside;
                    break;
            }
        }

        else if(cardSuit == Suit.HEARTS)
        {
            switch (cardValue)
            {
                case Value.ACE:
                    newCard.GetComponent<Image>().sprite = AceH;
                    break;
                case Value.TWO:
                    newCard.GetComponent<Image>().sprite = TwoH;
                    break;
                case Value.THREE:
                    newCard.GetComponent<Image>().sprite = ThreeH;
                    break;
                case Value.FOUR:
                    newCard.GetComponent<Image>().sprite = FourH;
                    break;
                case Value.FIVE:
                    newCard.GetComponent<Image>().sprite = FiveH;
                    break;
                case Value.SIX:
                    newCard.GetComponent<Image>().sprite = SixH;
                    break;
                case Value.SEVEN:
                    newCard.GetComponent<Image>().sprite = SevenH;
                    break;
                case Value.EIGHT:
                    newCard.GetComponent<Image>().sprite = EightH;
                    break;
                case Value.NINE:
                    newCard.GetComponent<Image>().sprite = NineH;
                    break;
                case Value.TEN:
                    newCard.GetComponent<Image>().sprite = TenH;
                    break;
                case Value.JACK:
                    newCard.GetComponent<Image>().sprite = JackH;
                    break;
                case Value.QUEEN:
                    newCard.GetComponent<Image>().sprite = QueenH;
                    break;
                case Value.KING:
                    newCard.GetComponent<Image>().sprite = KingH;
                    break;
                default:
                    newCard.GetComponent<Image>().sprite = backside;
                    break;
            }
        }

        else if(cardSuit == Suit.JOKER)
        {
            switch(cardValue)
            {
                case Value.JOKER1:
                    newCard.GetComponent<Image>().sprite = Joker1;
                    break;
                case Value.JOKER2:
                    newCard.GetComponent<Image>().sprite = Joker2;
                    break;
                default:
                    newCard.GetComponent<Image>().sprite = backside;
                    break;
            }
        }
    }

}
