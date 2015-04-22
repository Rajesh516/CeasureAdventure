using UnityEngine;
using System.Collections;

public class CircularProgressBar : MonoBehaviour {
	public float Timer = 10;
	public TextMesh TimeText;
	float f = 0;
	bool NotStarted = true;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void OnEnable(){
		NotStarted = false;
		f = 0.1f;
	}

	void OnDisable(){
		NotStarted = true;
	}

	void Update () {

		if (NotStarted)
			return;

		//renderer.material.SetFloat("_Cutoff", Mathf.InverseLerp(0, Screen.width, Input.mousePosition.x)); 
		f += (Time.fixedDeltaTime) ;

		renderer.material.SetFloat("_Cutoff", Mathf.InverseLerp(Timer, 0f,f)); 
		TimeText.text = (Timer - (int)f).ToString ();
		if (f > Timer) {
			GameOverManager.Instance.HideTimer();		
		}
	}
}
