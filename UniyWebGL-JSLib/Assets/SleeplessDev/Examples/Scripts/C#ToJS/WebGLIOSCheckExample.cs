using UnityEngine;
using SleeplessDev;

public class WebGLIOSCheckExample : MonoBehaviour
{
	private IOSFinder iosFinder;

	void Start()
	{
		iosFinder = gameObject.AddComponent<IOSFinder>();
		bool isIOS = iosFinder.IsIOS();

		if (isIOS)
		{
			Debug.Log("Running on an iOS device");
			// Add iOS-specific code here
		}
		else
		{
			Debug.Log("Not running on an iOS device");
			// Add non-iOS-specific code here
		}
	}
}
