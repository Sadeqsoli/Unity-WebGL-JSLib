using UnityEngine;
using System.Runtime.InteropServices;

namespace SleeplessDev
{
	public class DownloadingImage : MonoBehaviour
	{
		[DllImport("__Internal")]
		private static extern void ImageDownloader(string cloudUrl, string localUrl);

		public void DownloadImage(string cloudUrl, string localUrl)
		{
#if !UNITY_EDITOR && UNITY_WEBGL
            ImageDownloader(cloudUrl, localUrl);
#else
			Debug.Log("Image downloading is only supported in WebGL builds.");
#endif
		}
	}
}
