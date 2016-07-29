using UnityEngine;
using System.Collections;

public class Title : Singleton<Title> {

	// Use this for initialization
	public override void Initialize ()
	{
		Interstitial.Instance.ShowGamestart ();
	}

	// Update is called once per frame
	void Update () {
	
	}
}
