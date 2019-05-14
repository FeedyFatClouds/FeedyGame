
using UnityEngine;

public class camer : MonoBehaviour {

    [SerializeField]
    private float smoothSpeed = 0.25f;
    public Vector3 offset;

    public Transform target;
   

     void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition; 
    }
}
