using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameControllerInfinite : MonoBehaviour {

    //Global Variables
    public Text countText;
    public Text stillGoText;
    public ParticleSystem fireworks;


    private int count;
    private GameObject infinite;


    // Use this for initialization
    void Start()
    {
        count = 0;
        SetCountText();
        stillGoText.text = "";
        GameObject fireworkObject = GameObject.FindWithTag("Fireworks");
        fireworks = fireworkObject.GetComponent<ParticleSystem>();
        var em = fireworks.emission;
        em.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //AddOne() increments the score count and updates the GUI Text
    public void AddOne()
    {
        count++;
        SetCountText();
    }

    //SetCountText() updates the count to the screen and displays 
    //Collect initial 12, then spawn infinitely
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {   
            //Set the fireworks to go off anyways as encouragement
            GameObject fireworkObject = GameObject.FindWithTag("Fireworks");
            fireworks = fireworkObject.GetComponent<ParticleSystem>();
            var em = fireworks.emission;
            em.enabled = true;

            stillGoText.text = "It's Not Over Yet!";


            infinite = GameObject.FindWithTag("Infinite");
            if (!infinite.GetComponent<Renderer>().isVisible)
            {
                infinite.GetComponent<Renderer>().enabled = true;

            }      

        }
    }
}
