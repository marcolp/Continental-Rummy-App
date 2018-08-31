using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public string name;
    public int score;
    public List<Card> hand;
    public bool opened; //Whether or not the player has opened their hand ("gone down") 

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /** Deal this card to this player's hand */
    public void addToHand(Card c) {
        hand.Add(c);
    }

    /** Drop this card from this player's hand */
    public void removeFromHand(Card card) {
        for ( int i=0 ; i<hand.Count ; i++ )
            if ( hand[i]==card )
                hand.RemoveAt(i);
    }
}
