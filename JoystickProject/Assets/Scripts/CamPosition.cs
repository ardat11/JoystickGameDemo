using UnityEngine;

public class CamPosition : MonoBehaviour
{
    //public Transform cameraPivot; 

    public float rotationSpeed = 5f;

    [SerializeField] private Transform LifeGuard;




    private void Update()
    {

        if (CameraMoveJoystick.Instance.horizontalInput != 0)
        {
            float rotationAmount = rotationSpeed * CameraMoveJoystick.Instance.horizontalInput;
            LifeGuard.Rotate(Vector3.up, rotationAmount);

        }
        
        //RotateCamera(CameraMoveJoystick.Instance.horizontalInput, CameraMoveJoystick.Instance.verticalInput);
    }

    //private void RotateCamera(float horizontalInput, float verticalInput)
    //{
    //  
    //    float rotationAmount = rotationSpeed * Time.deltaTime;
    //    transform.RotateAround(cameraPivot.position, Vector3.up, horizontalInput * rotationAmount);
    //    transform.RotateAround(cameraPivot.position, transform.right, -verticalInput * rotationAmount);
    //}
}
