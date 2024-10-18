using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

        float coffeeTemperature = 85.0f;
        float hotLimitTemperature = 70.0f;
        float coldLimitTemperature = 40.0f;

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
                TemperatureTest();

            coffeeTemperature -= Time.deltaTime * 5f;
        }
    
    void TemperatureTest()
    {
        // if too hot
        if (coffeeTemperature > hotLimitTemperature)
        {
            print("GAHHHHHH IT SO HOT LIKE THE SUN");
        }
        // if is too cold
        else if (coffeeTemperature < coldLimitTemperature)
        {
            print("WHY IS IT COLD LIKE THE ARTIC OCEAN WAHHHHHHHH");
        }
        // if perfect
        else
        {
            print("hmmm i like my coffee like how i love my women...... i dont :) ");
        }
    }
}   