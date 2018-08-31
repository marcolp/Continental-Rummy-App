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
        if ( player.Count>8 )
            Debug.Log(TAG + "Get a room!");
        player.Add(new Player(name));
        adjustDecksInGame();
    }

    /** Do we need to add more decks to the game? */
    public void adjustDecksInGame() {
        switch ( player.Count ) {
            case 1:
            case 2:
            case 3:

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
}
