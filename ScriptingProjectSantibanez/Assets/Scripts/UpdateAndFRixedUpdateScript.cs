using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFRixedUpdateScript : MonoBehaviour
{

     void FixedUpdate ()
    {
        Debug.Log("FixedUpdate Time :" + Time.deltaTime);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update Time :" + Time.deltaTime);
    }
}
