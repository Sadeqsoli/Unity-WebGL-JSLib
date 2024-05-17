using UnityEngine;
using System.Runtime.InteropServices;

namespace SleeplessDev
{
	public class Example2 : MonoBehaviour
	{
		[DllImport("__Internal")]
		private static extern int AddNumbers(int a, int b);

		public int CallAddNumbers(int a, int b)
		{
#if !UNITY_EDITOR && UNITY_WEBGL
            return AddNumbers(a, b);
#else
			return a + b; // fallback for testing in the Unity editor
#endif
		}
	}
}
