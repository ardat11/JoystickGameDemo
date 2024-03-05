using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;


    private void Awake()
    {
        Instance = this;
    }
    public Rigidbody rb;
    public InputAction CONTROLPLS;
   
    
    public Vector2 movedirection = Vector2.zero;



    private void OnEnable()
    {
        CONTROLPLS.Enable();
    }

    private void OnDisable()
    {
        CONTROLPLS.Disable();
    }


    [SerializeField] private float horizontalvector;
    [SerializeField] private float verticalvector;
    public float speed;

    private void Update()
    {
        movedirection = CONTROLPLS.ReadValue<Vector2>();



    }
    private void FixedUpdate()
    {
        //rb.velocity = new Vector3(movedirection.x * speed , 0, movedirection.y * speed);

        transform.Translate(movedirection.x * speed * Time.deltaTime, 0, movedirection.y * speed * Time.deltaTime);
    }








}
