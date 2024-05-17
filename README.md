# Unity WebGL Helper

Helper scripts for Unity WebGL builds to facilitate JavaScript and Unity method calls.

## Features

- Easy integration of JavaScript libraries in Unity WebGL builds
- Simple method calls from JavaScript to Unity and vice versa

## Installation

Clone this repository and integrate the scripts into your Unity project.

## Usage

1. Place the JavaScript files in your project's WebGLTemplates folder.
2. Include the C# scripts in your Unity project.

### JavaScript Example

```javascript
// example.js
function UnityCallExample() {
    SendMessage('GameObjectName', 'MethodName', 'Message from JavaScript');
}
```
### Unity C# Example
```csharp
// ExampleUnityScript.cs
using UnityEngine;

public class ExampleUnityScript : MonoBehaviour
{
    void MethodName(string message)
    {
        Debug.Log("Message from JavaScript: " + message);
    }
}
```


### Image Downloader

This repository includes a helper for downloading images in WebGL builds.
The JavaScript library (`ImageDownloaderPlugin.jslib`) includes a function to download images

#### Unity C# Example
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using sleeplessDev;

public class WebGLImageDownloadExample : MonoBehaviour
{
	public DownloadingImage imageDownloader;

	void Start()
	{
		string imageUrl = "https://example.com/path/to/your/image.jpg"; // Replace with the actual URL of the image
		string fileName = "downloadedImage.jpg";

		imageDownloader = gameObject.AddComponent<DownloadingImage>();
		imageDownloader.DownloadImage(imageUrl, fileName);
	}
}

```
### iOS Checker

This repository includes a plugin to check if the current device is an iOS device. The plugin utilizes JavaScript to perform the check and provides a C# interface for easy usage within Unity.

### Audio Stream (Microphone Permission)

This repository includes a plugin to find an array of microphones .
## Unity Editor Extensions

This repository includes custom Unity editor extensions to facilitate the creation and management of JavaScript libraries for WebGL builds.

### Creating a JavaScript Library Template

You can create a new `.jslib` file with a template by following these steps:

1. In the Unity Editor, right-click in the `Project` window.
2. Select `Create` > `JS Script-Template`.

This will create a new `.jslib` file with a basic template to get you started.

## Contributing
Feel free to open issues or submit pull requests.

## License
This project is licensed under the MIT License.
