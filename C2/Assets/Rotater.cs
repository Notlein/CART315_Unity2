using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
    
{
    private bool rotate;
    public float rotationSpeed;
    public float posY;
    public float highPos;
    public PickerUpper player;
    // Start is called before the first frame update
    void Start()
    {
        posY = 0;
        highPos = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            rotate = true;

        }
        else {
            rotate = false;

        }
        
    }
    
    void FixedUpdate()
    {
        
    if (rotate && player.count > 0) { this.GetComponent<Transform>().Rotate(0, rotationSpeed, 0); }

        

        
        
    }
}
