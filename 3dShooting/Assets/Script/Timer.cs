using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	public int timeLimit=30;
	private float timeRemaining;
	private bool timerStarted;
	void Start () {
		ResetTimer ();
	
	}
	public void ResetTimer(){
				timeRemaining = timeLimit;
				timerStarted = false;
		}
	public void StartTimer(){
				timerStarted = true;
		}
	public void StopTimer(){
				timerStarted = false;
		}
	public float GetTimeRemaining(){
				return timeRemaining;
		}
	void Update (){
		if (timerStarted) {
						timeRemaining -= Time.deltaTime;
						if (timeRemaining <= 0) {
								timeRemaining = 0;
								timerStarted = false;
						}
				}
	
		guiText.text = "Time :" + timeRemaining;

	
	}
}
