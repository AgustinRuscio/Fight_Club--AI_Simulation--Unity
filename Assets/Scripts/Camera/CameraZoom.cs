//------------------------------//
//     Made by Agustin Ruscio   //
//------------------------------//


using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public Transform targetPoint;

    [SerializeField]
    private float minZoom = 30;

    [SerializeField]
    private float maxZoom = 30;

    [SerializeField]
    private float _speed = 10;

    private void Update() => Zoom();

    private void Zoom()
    {
        if (Input.GetKey(KeyCode.W))
        {
            float distanceToTarget = Vector3.Distance(transform.position, targetPoint.position);

            if (distanceToTarget >= minZoom)
                transform.position += transform.forward * _speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            float distanceToTarget = Vector3.Distance(transform.position, targetPoint.position);

            if (distanceToTarget <= maxZoom)
                transform.position -= transform.forward * _speed * Time.deltaTime;
        }
    }
}