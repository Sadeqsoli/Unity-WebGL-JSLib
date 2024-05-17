using UnityEngine;
using System.Runtime.InteropServices;

namespace SleeplessDev
{
	public class IOSFinder : MonoBehaviour
	{
		[DllImport("__Internal")]
		private static extern int CheckForWebGLIOS();

		public bool IsIOS()
		{
#if !UNITY_EDITOR && UNITY_WEBGL
            return CheckForWebGLIOS() == 1;
#else
			Debug.Log("Fallback for testing in the Unity editor");
			return false;
#endif
		}
	}
}
