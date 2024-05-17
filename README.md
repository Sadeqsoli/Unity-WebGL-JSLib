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
