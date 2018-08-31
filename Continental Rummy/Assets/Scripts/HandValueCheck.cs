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

    public bool isRun(List<Card> cardSet)
    {
        return false;
    }

    public bool isTrio(List<Card> cardSet)
    {
        Value tempValue = 0;
        int counter = 0;
        foreach(Card currentCard in cardSet)
        {
            if (counter == 0)
            {
                tempValue = currentCard.getValue();
                continue;
            }

            else
            {
                if(tempValue == currentCard.getValue())
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
        }
        return false;
    }
}
