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
## Contributing
Feel free to open issues or submit pull requests.

## License
This project is licensed under the MIT License.
