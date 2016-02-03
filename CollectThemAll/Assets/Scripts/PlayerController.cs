using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public float speed;
    public Text countText;
    public Text winText;
    
    private int count;

	// Use this for initialization
	void Start () {
        count = 0;
        SetCountText();
        winText.text = "";
	}
	
    // called per frame, before performing physics
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //        Vector3 movement = new Vector3(Input.acceleration.x, 0, -Input.acceleration.z);
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        transform.Translate(movement * Time.deltaTime * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PowerUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            winText.text = "You Win!";
        }
    }
}
