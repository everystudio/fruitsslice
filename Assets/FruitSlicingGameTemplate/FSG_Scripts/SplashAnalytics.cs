using UnityEngine;
using System.Collections;

public class SplashAnalytics : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		GoogleAnalytics.Instance.Log ("splash");

		Interstitial.Instance.Dummy ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
