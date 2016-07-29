﻿using UnityEngine;
using System.Collections;

public class GoogleAnalytics : GoogleAnalyticsBase<GoogleAnalytics> {

	public override void Initialize ()
	{
		base.Initialize ();
		propertyID_Common = "UA-77286676-7";
		propertyID_Android = "UA-77286676-8";
		propertyID_iOS = "UA-77286676-9";

		bundleID = "jp.everystudio.fruitsslice.standard";
		appName = "爽快☆フルーツカット";
		appVersion = "1";

		// ハートビート
		heartbeat ();

	}

}