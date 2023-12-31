//------------------------------//
//     Made by Agustin Ruscio   //
//------------------------------//


using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField]
    private float cameraSpeed = 100.0f;

    void Update() => MoveCamera();

    private void MoveCamera()
    {
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0, cameraSpeed * Time.deltaTime * -1, 0);
        else if (Input.GetKey(KeyCode.A))
            transform.Rotate(0, cameraSpeed * Time.deltaTime, 0);
    }
}