using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatement : MonoBehaviour
{
    float coffeTemperature = 85.0f;
    float hotLimitTempature = 70.0f;
    float coldLimitTempature = 40.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TempatureTest();

        coffeTemperature -= Time.deltaTime * 5f;

        void TempatureTest ()
        {
            if(coffeTemperature > hotLimitTempature)
            {
                print("Coffee is too hot.");
            }
            else if(coffeTemperature < coldLimitTempature)
            {
                print("Coffe is too cold.");
            }
            else
            {
                print("Coffee is just right.");
            }
        }
    }
}
