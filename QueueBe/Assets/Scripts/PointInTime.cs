using UnityEngine;

public class PointInTime {

	// this class is designed to store the position and rotation of a TimeBody object
	// at a given point in time

	public Vector3 position;
	public Quaternion rotation;

	public PointInTime (Vector3 _position, Quaternion _rotation)
	{
		position = _position;
		rotation = _rotation;
	}

}
