using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** Behavior for each of the rounds of the game. */

public class Round : MonoBehaviour {
    private List<Player> player;
    private int ROUND; //the current round of the game
	private int MAX; //the maximum number of rounds for each game
	private int triosNeeded;
	private int runsNeeded;

    private string TAG = "RD ";

	// Use this for initialization
	void Start () {
		ROUND = 0;
		MAX = 7;
	}
	
	// Update is called once per frame
	void Update () {
        run();
        //Debug.Log(TAG + " In round " + getRound());
        foreach ( Player x in player )
        {
            if ( x.hand.Count==0 )
                endRound(x);
        }
    }

    /** Necessary? bc players' hands update per turn */
    public void setPlayers(List<Player> p) {
        player = p;
    }

    /** Game Manager sets the round of the game in play. */
    public void run() {
        switch ( ROUND ) {
            case 0:
                ROUND++; //round starts at 0
                break;
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
                Debug.Log(TAG + " y u do dis?");
                break;
        }
    }
	
	/** In what round is the game currently playing?
	  * @returns the current round as an integer */
	public int getRound() {
		return ROUND;
	}
	
	/** Has this round completed its play?
	  * @returns true if this round has its winning conditions met, false otherwise */
	public bool isDone() {
        return ( getRound()>0 && getRound()<=MAX );
	}
	
	/** What is the maxmimum number of rounds to play?
	  * @returns the integer MAX, the max number of rounds per game */
	public int getLastRound() {
		return MAX;
	}

    /** Each round requires t trios and s straights to complete. */
    public void triosAndStraights(int t, int r) {
		if ( t==triosNeeded && r==runsNeeded ) {
			Debug.Log(TAG + " Have trios=" + t+ ", runs=" + r + ", to complete round=" + getRound());
            
        }
    }

    public void endRound(Player p)
    {
        Debug.Log(TAG + " Player " + p.name + " has won round " + getRound());
        ROUND++;
        HandValueCheck hvc = new HandValueCheck();
        foreach ( Player l in player ) {
            l.updateScore(hvc.getScore(l.hand));
        }
    }
}
