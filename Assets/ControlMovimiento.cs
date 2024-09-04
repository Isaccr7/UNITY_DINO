using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ControlMovimiento: MonoBehaviour
{
    // Start is called before the first frame update


    [SerializeField] private float velocidad;

    private FixedJoystick fixedJoystick;

    private Rigidbody rigidbody;


    private void OnEnable()
    {
        fixedJoystick = FindObjectOfType<FixedJoystick>();
        rigidbody = GetComponent<Rigidbody>();

    }

    private void FixedUpdate()
    {
        float xVal = fixedJoystick.Horizontal;
        float yVal = fixedJoystick.Vertical;

        Vector3 movement = new Vector3(xVal,0 ,yVal);

        rigidbody.velocity = movement * velocidad;


        if (xVal != 0 && yVal != 0)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movement, Vector3.up);

            float angel = math.atan2(xVal,yVal) * Mathf.Rad2Deg;    

            //transform.eulerAngles= new Vector3(transform.eulerAngles.x,Mathf.Atan2(xVal,yVal)*Mathf.Rad2Deg,transform.eulerAngles.z);
            transform.rotation = Quaternion.Euler(0, angel, 0);
   
        }

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
