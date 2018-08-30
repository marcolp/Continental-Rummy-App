using Unity.Engine;

/** This is class of a deck of cards used in the game. */

public class Deck : MonoBehaviour {
	private ArrayList(Card) card;
	
	public Start() { }
	
	public Update() { }
	
	public void create() {
		card = new ArrayList(Card);
		for ( int i=0 ; i<52 ; i++ )
			card.Add(new Card.init(i%13,i%4);
		card.Add(new Card.init(14,-1));
		card.Add(new Card.init(15,-1));
	}
}