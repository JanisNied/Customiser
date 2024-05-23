using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonText : MonoBehaviour
{
    [SerializeField] private TMP_InputField textField_nm;
    [SerializeField] private TMP_InputField textField_yr;
    [SerializeField] private TMP_Text textResult;
    [SerializeField] private int longestLivedPerson;
    private int currentYear;
    private void Start()
    {
        currentYear = DateTime.Now.Year;
    }
    public void BtnMethod()
    {
        string name = "";
        int textAge = 0;
        int.TryParse(textField_yr.text, out textAge);
        int age = currentYear - textAge;
        if (age > 0 && age <= longestLivedPerson && !string.IsNullOrEmpty(textField_nm.text))
        {
            Debug.Log("logged text change..");
            name = char.ToUpper(textField_nm.text[0]) + textField_nm.text.Substring(1).ToLower();
            textResult.text = string.Format("Your name is {0} and your age is {1}.", name, age);
        }

    }
}
