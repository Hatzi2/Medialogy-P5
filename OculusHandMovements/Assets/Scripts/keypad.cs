using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class keypad : MonoBehaviour
{
    public string outputNumber;
    [SerializeField] TextMeshProUGUI m_Object;
    private string code = "";

    void OnCollisionEnter(Collision collision)
    {
            code += outputNumber;
            int codeLength = code.Length;

            m_Object.text = code;

            if (codeLength == 4)
            {
                Debug.Log(code);
            }            
    }
}
