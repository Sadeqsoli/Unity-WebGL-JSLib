using UnityEngine;
using sleeplessDev;

public class WebGLAudioStreamExample : MonoBehaviour
{
	private AudioStream audioStream;

	void Start()
	{
		//TODO: you need to add a button for start and stoping the mic to get more control
		audioStream = gameObject.AddComponent<AudioStream>();
		audioStream.StartLocalStream();
	}
}
