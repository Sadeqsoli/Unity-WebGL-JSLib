using UnityEngine;
using System.Runtime.InteropServices;

namespace SleeplessDev
{
	public class Example3 : MonoBehaviour
	{
		[DllImport("__Internal")]
		private static extern void PrintMessage(string str);

		public void CallPrintMessage(string message)
		{
#if !UNITY_EDITOR && UNITY_WEBGL
            PrintMessage(message);
#else
			Debug.Log(message); // fallback for testing in the Unity editor
#endif
		}
	}
}
