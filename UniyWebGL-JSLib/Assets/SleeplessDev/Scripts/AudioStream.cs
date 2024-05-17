using UnityEngine;
using System.Runtime.InteropServices;

namespace sleeplessDev
{
	public class AudioStream : MonoBehaviour
	{
		[DllImport("__Internal")]
		private static extern void GetLocalStream();

		public void StartLocalStream()
		{
#if !UNITY_EDITOR && UNITY_WEBGL
            GetLocalStream();
#else
			Debug.Log("Local audio stream is only supported in WebGL builds.");
#endif
		}
	}
}
