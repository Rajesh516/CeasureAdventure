using UnityEngine;
using System.Collections;

public class HeartVisibleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//print ("gameObject.renderer.enabled--------" + PlayerManager.Instance.amIAlive);
		if (PlayerManager.Instance.amIAlive)
						gameObject.transform.localScale = new Vector3 (10.2f, 9.1f, 1.0f);
		else
			gameObject.transform.localScale = new Vector3 (0f, 9.1f, 1.0f);
	}

	//public void HeartVisibility
}
