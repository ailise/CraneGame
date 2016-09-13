using UnityEngine;
using System.Collections;

public class BallMove : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position = new Vector3 (transform.position.x - 3 * Time.deltaTime,
				transform.position.y,
				transform.position.z);
		}
        
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position = new Vector3 (transform.position.x + 3 * Time.deltaTime,
				transform.position.y,
				transform.position.z);
		}
        
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position = new Vector3 (transform.position.x,
				transform.position.y,
				transform.position.z - 3 * Time.deltaTime);
		}
        
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.position = new Vector3 (transform.position.x,
				transform.position.y,
				transform.position.z + 3 * Time.deltaTime);
		}
	
	}
}
