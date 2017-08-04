using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {
	
	private int score = 0;
	//得点を表示するテキスト
	private GameObject scoreText;

	// Use this for initialization
	void Start () {
		//シーン中のScoreTextオブジェクトを取得
		this.scoreText = GameObject.Find("ScoreText");
	}
	
	// Update is called once per frame
	void Update () {
		this.scoreText.GetComponent<Text> ().text = score + "点";
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "SmallStarTag") {
			score += 10;
		} else if (other.gameObject.tag == "LargeStarTag") {
			score += 20;
		} else if (other.gameObject.tag == "SmallCloudTag") {
			score += 15;
		} else if (other.gameObject.tag == "LargeCloudTag") {
			score += 25;
		}
	}
}