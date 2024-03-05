using UnityEngine;
using UnityEngine.UI;

public class CameraMoveJoystick : MonoBehaviour
{
    public static CameraMoveJoystick Instance;

    public RectTransform joystickBackground;
    public RectTransform joystickHandle;

    private Vector2 joystickPosition;
    public bool isJoystickPressed = false;
    public float horizontalInput;
    public float verticalInput;


    private Vector2 initialJoystickPosition; 

    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            if (RectTransformUtility.RectangleContainsScreenPoint(joystickBackground, Input.mousePosition))
            {
                isJoystickPressed = true;

                
                Vector2 localPoint;
                if (RectTransformUtility.ScreenPointToLocalPointInRectangle(joystickBackground, Input.mousePosition, null, out localPoint))
                {
                    initialJoystickPosition = localPoint;
                }
            }
        }

        if (isJoystickPressed)
        {
            
            Vector2 localPoint;
            if (RectTransformUtility.ScreenPointToLocalPointInRectangle(joystickBackground, Input.mousePosition, null, out localPoint))
            {
               
                joystickPosition = localPoint - initialJoystickPosition;
                joystickHandle.localPosition = joystickPosition;

               
                float distance = Vector2.Distance(Vector2.zero, joystickPosition);
                if (distance > joystickBackground.sizeDelta.x / 2f)
                {
                    joystickPosition = joystickPosition.normalized * (joystickBackground.sizeDelta.x / 2f);
                    joystickHandle.localPosition = joystickPosition;
                }

                
                UpdatePlayerMovement();
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            
            isJoystickPressed = false;
            joystickPosition = Vector2.zero;
            joystickHandle.localPosition = Vector2.zero;

            
            UpdatePlayerMovement();
        }
    }

    private void UpdatePlayerMovement()
    {
        
        horizontalInput = joystickPosition.x / (joystickBackground.sizeDelta.x / 2f);
        verticalInput = joystickPosition.y / (joystickBackground.sizeDelta.y / 2f);

        
    }
}
