using Unity.Engine;

/** This is class for each instance of a Card (name and suit). */

public class Card : MonoBehaviour {
	public enum Name {
		ACE = 1,
		TWO = 2,
		THREE = 3,
		FOUR = 4,
		FIVE = 5,
		SIX = 6,
		SEVEN = 7,
		EIGHT = 8,
		NINE = 9,
		TEN = 10,
		JACK = 11,
		QUEEN = 12,
		KING = 13,
		JOKER1 = 14,
		JOKER2 = 15
	}

	public enum Suit {
		SPADES,
		DIAMONDS,
		HEARTS,
		CLUBS
	}

	//todo use this for any reason, since this is for GUI?
	public enum Color {
		BLACK,
		RED
	}

	private string name;
	private string suit;
	private bool disposed; //has the card been played?
	private bool inGame; //is the card in the game play?

	public Start() { }
	
	public Update() { }
	
	/** Creates this instance of a Card to a name and suit */
	public void init(int type, int st) {
		name = GetName(typeof(Name),type);
		suit = GetName(typeof(Suit),st);
	}
	
	/** ********** METHODS FOR ACCESSORS ********** */
	public string getName() {
		return name;
	}
	
	public string getSuit() {
		return suit;
	}
	
	/** ********** METHODS FOR CARD BEHAVIOR IN GAME ********** */
	public void addToGame() {
		inGame = true;
	}
	
	public bool isInGame() {
		return inGame;
	}
	
	public bool isDisposed() {
		return disposed;
	}
	
	public void dispose() {
		disposed = true;
	}
}