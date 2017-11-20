using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;


public class TestAnalitics : MonoBehaviour {


	int	mClickCount=0;

	float	mTime=0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		mTime += Time.deltaTime;
		
	}


	public	void	TestEvent()
	{
		Analytics.CustomEvent ("TestClick", new Dictionary<string, object> {
			{ "Platform", Application.platform.ToString() },
			{ "ClickCount", ++mClickCount },
			{ "DeltaTime", mTime }
		});
		mTime = 0;
	}
}
