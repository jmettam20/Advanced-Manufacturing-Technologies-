using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{

    void Start()
    {
        Cursor.visible = false;
        Screen.lockCursor = true;
    }


    [SerializeField] private Vector2 sensitivity;
    private Vector2 rotation;

    private Vector2 GetInput() {
        Vector2 input = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        return input; 
    }

    private void Update() {
        Vector2 wantedVelocity = GetInput() * sensitivity;
        rotation += wantedVelocity * Time.deltaTime;
        transform.localEulerAngles = new Vector3(rotation.y, rotation.x, 0); 
    
    }
}
