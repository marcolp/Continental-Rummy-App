using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** Behavior for each of the rounds of the game. */

public class Round : MonoBehaviour {
    private List<Player> player;
    private int ROUND; //the current round of the game
	private int MAX; //the maximum number of rounds for each game
	private HandValueCheck check;
	private bool running; //is the round currently started and running?
	private int triosNeeded;
	private int runsNeeded;

    private string TAG = "RD ";

	// Use this for initialization
	void Start () {
		ROUND = 0;
		MAX = 7;
		running = false;
	}
	
	// Update is called once per frame
	void Update () { }

    /** Necessary? bc players' hands update per turn */
    public void setPlayers(List<Player> p) {
        player = p;
    }

    /** Game Manager sets the round of the game in play. */
    public void run() {
		ROUND++; //round starts at 0
		running = true;
        switch ( ROUND ) {
            case 1:
				triosNeeded=2;
				runsNeeded=0;
                break;
            case 2:
				triosNeeded=1;
				runsNeeded=1;
                break;
            case 3:
				triosNeeded=0;
				runsNeeded=2;
                break;
            case 4:
				triosNeeded=3;
				runsNeeded=0;
                break;
            case 5:
				triosNeeded=2;
				runsNeeded=1;
                break;
            case 6:
				triosNeeded=1;
				runsNeeded=2;
                break;
            case 7:
				triosNeeded=0;
				runsNeeded=3;
                break;
            default:
                Debug.Log(TAG + "y u do dis?");
                break;
        }
		triosAndStraights(triosNeeded,runsNeeded);
    }
	
	/** In what round is the game currently playing?
	  * @returns the current round as an integer */
	public int getRound() {
		return ROUND;
	}
	
	/** Has this round completed its play?
	  * @returns true if this round has its winning conditions met, false otherwise */
	public bool isDone() {
		return running;
	}
	
	/** What is the maxmimum number of rounds to play?
	  * @returns the integer MAX, the max number of rounds per game */
	public int getLastRound() {
		return MAX;
	}
	
	/** Each round has a specific amount of cards required to begin.
	  * @returns the number of cards (as an integer) required to start the current round */
	public int cardsNeededToOpen() {
        switch ( ROUND ) {
            case 1:
                return 6;
            case 2:
				return 7;
            case 3:
                return 8;
            case 4:
                return 9;
            case 5:
                return 10;
            case 6:
                return 11;
            case 7:
                return 12;
            default:
                Debug.Log(TAG + "*thronking*");
                return -1;
        }
	}

    /** Each round requires t trios and s straights to complete. */
    public void triosAndStraights(int t, int r) {
		if ( t==triosNeeded && r==runsNeeded ) {
			running = false;
            Debug.Log("have trios=" +t+ ", runs=" + r + ", to complete round=" +ROUND);
        }
    }
}
