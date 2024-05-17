using UnityEngine;
using SleeplessDev;

public class ConnectToJSLibraryExample : MonoBehaviour
{
	void Start()
	{
		// Example usage
		Example1 example1 = gameObject.AddComponent<Example1>();
		example1.CallAlertHello();

		Example2 example2 = gameObject.AddComponent<Example2>();
		int sum = example2.CallAddNumbers(3, 4);
		Debug.Log("Sum: " + sum);

		Example3 example3 = gameObject.AddComponent<Example3>();
		example3.CallPrintMessage("Hello Unity WebGL");

		Example4 example4 = gameObject.AddComponent<Example4>();
		int product = example4.CallMultiplyNumbers(5, 6);
		Debug.Log("Product: " + product);
	}
}
