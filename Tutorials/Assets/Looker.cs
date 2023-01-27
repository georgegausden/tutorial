using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looker : MonoBehaviour
{
    public GameObject target;
    private bool rotate;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.R))
        {
            rotate = true;
        }
        else
        {
            rotate = false;
        }
    }

    private void FixedUpdate()
    {
      if (rotate){
         this.GetComponent<Transform>().LookAt(target.GetComponent<Transform>());
        }
      
    }
}
