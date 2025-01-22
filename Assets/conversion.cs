using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ConversionOfUnits : MonoBehaviour
{
    public float PHP;
    public float Dollars;
    public float Yen;
    public float Rupees;
    public float HKD;
    public float Pounds;
    public Textmeshpro
    //UI Variables
    public TMP_InputField inputfield;

    /*
    public void ActivateDiddy()
    {
        if (images.activeSelf)
        {
            images.SetActive(false);
        }
        else
        {
            images.SetActive(true);
        }
    }
    */
    //function that converts PHP to Dollars
    public void ToUsd()
    {
        string inputValue = inputfield.text;
        float numericValue;
        if ((float.TryParse(inputValue, out numericValue)))
        {
            //Debug.Log
            Debug.Log(numericValue);
            PHP = numericValue * Dollars;
            convertedValue.text = PHP.ToString();

        }
        else
        {
            Debug.Log("Invalid Input");
        }
    }


    //function that converts PHP to Yen
    public void ToYen()
    {
        string inputValue = inputfield.text;
        float numericValue1;
        if ((float.TryParse(inputValue, out numericValue1)))
        {
            //Debug.Log PHP to Yen
            Debug.Log(numericValue1);
            PHP = numericValue1 * Yen;
            convertedValue1.text = PHP.ToString();

        }
        else
        {
            Debug.Log("Invalid Input");
        }
    }


    //function that converts PHP to Rupees
    public void ToRupees()
    {
        string inputValue = inputfield.text;
        float numericValue2;
        if ((float.TryParse(inputValue, out numericValue2)))
        {
            //Debug.Log PHP to Rupees
            Debug.Log(numericValue2);
            PHP = numericValue2 * Rupees;
            convertedValue2.text = PHP.ToString();
        }
        else
        {
            Debug.Log("Invalid Input");
        }
    }

    //function that converts PHP to HKD
    public void ToHKD()
    {
        string inputValue = inputfield.text;
        float numericValue3;
        if ((float.TryParse(inputValue, out numericValue3)))
        {
            //Debug.Log PHP to HKD
            Debug.Log(numericValue3);
            PHP = numericValue2 * HKD;
            convertedValue2.text = PHP.ToString();
        }
        else
        {
            Debug.Log("Invalid Input");
        }
    }

    //function that converts PHP to Pounds
    public void ToPounds()
    {
        string inputValue = inputfield.text;
        float numericValue4;
        if ((float.TryParse(inputValue, out numericValue4)))
        {
            //Debug.Log PHP to Pounds
            Debug.Log(numericValue4);
            PHP = numericValue2 * Pounds;
            convertedValue2.text = PHP.ToString();
        }
        else
        {
            Debug.Log("Invalid Input");
        }
    }
}
