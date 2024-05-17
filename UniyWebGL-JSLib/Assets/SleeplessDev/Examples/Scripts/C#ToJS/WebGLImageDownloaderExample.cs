using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SleeplessDev;

public class WebGLImageDownloadExample : MonoBehaviour
{
	 DownloadingImage imageDownloader;

	void Start()
	{
		string imageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c4/Unity_2021.svg/1199px-Unity_2021.svg.png"; // Replace with the actual URL of the image
		string fileName = "downloadedImage.jpg";

		imageDownloader = gameObject.AddComponent<DownloadingImage>();
		imageDownloader.DownloadImage(imageUrl, fileName);
	}
}
