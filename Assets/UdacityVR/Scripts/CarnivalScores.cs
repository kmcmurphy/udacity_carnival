using System;
using UnityEngine;
using TMPro;

public class CarnivalScores : MonoBehaviour {

	[SerializeField]
	private int TeddyBearPointsMin = 2000;

	[SerializeField]
	private GameObject TeddyBear;

	[SerializeField]
	private TextMeshPro plinkoScore;
	[SerializeField]
	private TextMeshPro plinkoScore2;
	[SerializeField]
	private TextMeshPro wheelScore;
	[SerializeField]
	private TextMeshPro wheelScore2;
	[SerializeField]
	private TextMeshPro coinScore;
	[SerializeField]
	private TextMeshPro coinScore2;

	public static CarnivalScores Instance;

	private int plinkoPoints;
	private int wheelPoints;
	private int coinPoints;

	void Awake() {
		if (Instance == null)
			Instance = this;

		TeddyBear.SetActive(false);
	}

	void OnDestroy() {
		if (Instance = this)
			Instance = null;
	}

	// Update is called once per frame
	void Update () {
		plinkoScore.text = "Plinko: " + plinkoPoints.ToString("0000");
		plinkoScore2.text = "Plinko: " + System.Environment.NewLine + plinkoPoints.ToString("0000");
		wheelScore.text  = "Wheel: " + wheelPoints.ToString("0000");
		wheelScore2.text  = "Wheel:" + System.Environment.NewLine + wheelPoints.ToString("0000");
		coinScore.text = "Coins: " + coinPoints.ToString("0000");
		coinScore2.text = "Coins:" + System.Environment.NewLine + coinPoints.ToString("0000");

		if (plinkoPoints + wheelPoints + coinPoints >= TeddyBearPointsMin) {
			TeddyBear.SetActive(true);
		}
	}

	public void IncrementPlinkoScore(float points) {
		plinkoPoints += (int) points;
	}

	public void IncrementWheelScore(float points) {
		wheelPoints += (int) points;
	}

	public void IncrementCoinScore() {
		coinPoints += 1000;
	}
}
