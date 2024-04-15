using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    private Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend  = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        // if(Input.GetKey(KeyCode.LeftControl)){
        //     rend.material.color = Color.blue;
        // }else{
        //     rend.material.color = Color.white;
        // }

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * verticalInput * rotationSpeed * Time.deltaTime);
    }



    // Invoke Unity  Event
    // public void MoveEvent(InputAction.CallbackContext text){
    //     verticalInput = text.ReadValue<Vector2>().y;
    // }   
    // public void ColorEvent(InputAction.CallbackContext text){
    //     Debug.Log(text);
    // }


    // Send Mensage
    public void OnMove(InputValue value){
        verticalInput = value.Get<Vector2>().y;
    }  
    public void OnColor(InputValue value) {
        if(value.isPressed){
            rend.material.color = Color.blue;

        }else{
            rend.material.color = Color.white;
        }
    }
}
