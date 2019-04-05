using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class FlipCard : MonoBehaviour {

    public Sprite back;
    public Sprite front;
    public bool isFacedown; //Whether the card is facedown or not

	// Use this for initialization
	void Start () {
        front = gameObject.GetComponent<Image>().sprite;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Flip()
    {
        if (isFacedown == true)
        {
            isFacedown = false;
            gameObject.GetComponent<Image>().sprite = front;
        }

        else
        {
            isFacedown = true;
            gameObject.GetComponent<Image>().sprite = back;
        }
    }
}
