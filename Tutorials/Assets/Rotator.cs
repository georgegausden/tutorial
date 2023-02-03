using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    //making the variable public makes it changeable in the editor
    public float rotationSpeed = 0.3f;
    public PickerUpper player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { //can't assume that it will happen at a regular interval (frames called), depends on computer..
      

    }

    //FixedUpdate is garanteed to work (it will not miss any frames)
    void FixedUpdate()
    {
        if (player != null)
        {

            //we want to rotate the object
            if (player.count >= 3)
            {
                this.GetComponent<Transform>().Rotate(0, rotationSpeed, 0);
            }
        }
    }
}
