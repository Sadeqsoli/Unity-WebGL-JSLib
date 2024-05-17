using UnityEngine;
using System.Runtime.InteropServices;

namespace SleeplessDev
{
	public class Example1 : MonoBehaviour
	{
		[DllImport("__Internal")]
		private static extern void AlertHello();

		public void CallAlertHello()
		{
#if !UNITY_EDITOR && UNITY_WEBGL
            AlertHello();
#endif
		}
	}
}
