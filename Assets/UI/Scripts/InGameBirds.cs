using UnityEngine;
using System.Collections;

public class InGameBirds : MonoBehaviour {
	TextMesh textMesh;
	// Use this for initialization
	void Start () {
		textMesh = GetComponent<TextMesh> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.name == "BirdHit")
			textMesh.text = "" + LevelManager.Instance.TorpedoExplodedGetter ();
		if (gameObject.name == "CrocHit")
						textMesh.text = "" + LevelManager.Instance.CrocodileExplodedGetter ();
		if (gameObject.name == "SkunkHit")
						textMesh.text = "" + LevelManager.Instance.SkunkExplodedGetter ();
	}
}
