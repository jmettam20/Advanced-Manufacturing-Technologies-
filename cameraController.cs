using UnityEngine;

public class cameraController : MonoBehaviour
{

	public Transform target; //look at this

	public float smoothSpeed = 0.125f; // speed of cam movement 
	public Vector3 offset; //offset fromplayer 



	void FixedUpdate()
	{
		Vector3 desiredPosition = target.position + offset; // add offset to player position got get the camera offset 
		Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);//make smooth pos
		transform.position = smoothedPosition; //change camera pos to smooth pos 

		
	}

	
}