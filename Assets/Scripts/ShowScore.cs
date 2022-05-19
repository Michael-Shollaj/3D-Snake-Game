using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour {

	public Text scoreText;
	public Text highScore;

	// Use this for initialization
	void Start () {
		highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
		scoreText.text = "Score: " + Score.score;
	}
	
	// Update is called once per frame
	void Update ()
	{

		
	}
}
