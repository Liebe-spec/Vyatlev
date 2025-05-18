using UnityEngine;

public enum CameraRotate { None, X, Y }
public class PlayerRotate : MonoBehaviour
{
    
    public CameraRotate CameraRotate = CameraRotate.None;
    public float SpeedRotation = 10f;
    public float maxAngle = 45f;
    public float minAngle = -45f;
    private float currentAngle = 0f;
    
    void Update()
    {
        float x = 0;
        float y = 0;
        
        switch (CameraRotate)
        {
            case CameraRotate.X:
                x = Input.GetAxis("Mouse X") * Time.deltaTime * SpeedRotation;
                y = Input.GetAxis("Mouse X") * Time.deltaTime * SpeedRotation;
                break;
            case CameraRotate.Y:
                y = -Input.GetAxis("Mouse Y") * Time.deltaTime * SpeedRotation;
                x = -Input.GetAxis("Mouse Y") * Time.deltaTime * SpeedRotation;
                currentAngle = Mathf.Clamp(currentAngle + x, minAngle, maxAngle);
                break;
        }
        transform.Rotate(y, x, 0);
        transform.localEulerAngles = new Vector3(
        currentAngle,
                    transform.localEulerAngles.y,
                    transform.localEulerAngles.z
                    );
        transform.Rotate(0, y, 0); 
    }
}
