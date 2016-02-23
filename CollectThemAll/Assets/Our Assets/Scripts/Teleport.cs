using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {
    //global variables
    private Vector3 startingPosition;
    private GameControllerInfinite gameController;

    // Use this for initialization
    void Start () {

        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameControllerInfinite>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
        startingPosition = transform.localPosition;
        SetGazedAt(false);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    /*SetGazedAt() changes the color of the collectable based on whether or not we're looking at it. 
    Red for not, green for yes.*/
    public void SetGazedAt(bool gazedAt)
    {
        GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.red;
    }

    /*InfiniteCollect() is used in the infinite level. Will add 1 to the score and teleport the 
    collectible randomly in the field.*/
    public void InfiniteCollect()
    {
        gameController.AddOne();
        transform.localPosition = new Vector3(Random.Range(-9,9),0.5f,Random.Range(-9,9));

    }
}
