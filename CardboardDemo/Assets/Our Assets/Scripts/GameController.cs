using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour
{

    //Global Variables
    public Text countText;
    public Text winText;
    public ParticleSystem fireworks;


    private int count;


    //Initialization of variables
    //Grabs firework particle system and tells it to not emmit. 
    void Start()
    {
        count = 0;
        SetCountText();
        winText.text = "";
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
    //"You Win" to the screen when collectables all collected
    //Grabs firework particle system and tells it to start emmiting when goal is reached. 
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            winText.text = "You Win!";
            GameObject fireworkObject = GameObject.FindWithTag("Fireworks");
            fireworks = fireworkObject.GetComponent<ParticleSystem>();
            var em = fireworks.emission;
            em.enabled = true;

        }
    }
}
