using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
    public List<Player> player;
    public List<Deck> deck;
    private string TAG = "GM "; //used for debugging to console

	// Use this for initialization
	void Start () {
        player = new List<Player>();
        deck = new List<Deck>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /** Adding a player to the game */
    public void addPlayer(string name) {
        if ( player.Count>7 )
            Debug.Log(TAG + "Get a room!");
        player.Add(new Player());
        player[player.Count-1].name = name;
        adjustDecksInGame();
    }

    /** Do we need to add more decks to the game? */
    private void adjustDecksInGame() {
        switch ( player.Count ) {
            case 1:
            case 2:
            case 3:
                if ( deck.Count==1 )
                    return;
                deck.Add(new Deck());
                break;
            case 4: //4 players use 2 decks
                if ( deck.Count==2 )
                    return;
                deck.Add(new Deck());
                break;
            case 5:
            case 6: //5-6 players use 3 decks
                if ( deck.Count==3 )
                    return;
                deck.Add(new Deck());
                break;
            case 7:
            case 8: //7-8 players use 4 decks
                if ( deck.Count==4 )
                    return;
                deck.Add(new Deck());
                break;
            default:

                break;
        }
    }

    /** Starting the game */
    public void start() {
        //shuffle the decks in the game
        CardOrderManipulation.shuffle(deck);
        //deal each player 12 cards
        dealToEachPlayer(12);
    }

    /** Deal the 'top' n cards of the deck. */
    private void dealToEachPlayer(int n) {
        Card c;
        foreach ( Player p in player )
            for ( int i=0 ; i<n ; i++ )
                if ( (c=dealFromDeck())!=null )
                    p.addToHand(c);
                else
                    Debug.Log(TAG + "idk fam we probs shoulda tested before mad-coding-seshes");
    }

    /** Deal from this deck of decks in the game. */
    private Card dealFromDeck() {
        if ( deck.Count>0 ) //if there are no decks to deal from, rip
            return null;
        if ( deck[deck.Count-1].isEmpty() ) //if the last deck is empty, remove it
            deck.RemoveAt(deck.Count-1);
        return deck[deck.Count-1].dealCard(); //return the 'top' card of the deck (last spot in the list)
    }
}
