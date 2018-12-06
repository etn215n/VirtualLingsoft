using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 70f;

	void Update ()
    {
        transform.localEulerAngles += new Vector3(0f, rotationSpeed * Time.deltaTime, 0f);
	}
}
