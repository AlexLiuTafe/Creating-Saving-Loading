using UnityEngine;

public class RotatingObject : PersistableObject
{
	[SerializeField]
	Vector3 angularVelocity;

	void Update()
	{
		transform.Rotate(angularVelocity * Time.deltaTime);
	}
}