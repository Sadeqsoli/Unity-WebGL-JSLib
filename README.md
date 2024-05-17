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
