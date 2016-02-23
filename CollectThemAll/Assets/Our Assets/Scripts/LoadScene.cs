using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void All()
    {
        SceneManager.LoadScene("PlayingFieldAll");
    }

    public void Infinite()
    {
        SceneManager.LoadScene("PlayingFieldInfinite");
    }
}
