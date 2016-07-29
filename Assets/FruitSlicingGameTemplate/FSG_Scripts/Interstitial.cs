using UnityEngine;
using System.Collections;
using NendUnityPlugin.AD;

public class Interstitial : Singleton<Interstitial> {

	#if UNITY_IPHONE
	const string API_KEY_GAMESTART = "381672aa77cf7874838ea6bb1da2fb19dc47ec17";
	const string SPOT_ID_GAMESTART = "634805";

	const string API_KEY_GAMECONTINUE = "79e39d3132bfc993a593b780f785bb94c2e39070";
	const string SPOT_ID_GAMECONTINUE = "634806";
	#elif UNITY_ANDROID
	const string API_KEY_GAMESTART = "c71949b5867e1ba841cf2d18cad33a747029dbc1";
	const string SPOT_ID_GAMESTART = "634801";

	const string API_KEY_GAMECONTINUE = "d3e1ed32b1646062e174ce7b23e1a538a42bf7b1";
	const string SPOT_ID_GAMECONTINUE = "634802";
	#else
	#endif

	public void Dummy(){
	}


	public override void Initialize ()
	{
		base.Initialize ();
		NendAdInterstitial.Instance.Load (API_KEY_GAMESTART, SPOT_ID_GAMESTART);
		NendAdInterstitial.Instance.Load (API_KEY_GAMECONTINUE, SPOT_ID_GAMECONTINUE);
	}

	public void ShowGamestart(){
		NendAdInterstitial.Instance.Show (SPOT_ID_GAMESTART);
	}
	public void ShowGamecontinue(){
		NendAdInterstitial.Instance.Show (SPOT_ID_GAMECONTINUE);
	}

}
