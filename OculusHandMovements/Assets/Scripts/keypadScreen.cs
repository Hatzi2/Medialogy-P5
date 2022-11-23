using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class keypadScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_Object;
    public Collider[] keyColliders;
    public GameObject door;
    private string keyVal;
    private string code = "1470";
    private int keyCount = 0;

    public void writeToScreen(string key)
    {
        keyVal += key;   
        m_Object.text = keyVal;
        keyCount++;
        if (keyCount == 4)
        {

            if(keyVal == code)
            {
                m_Object.text = "Unlocked";
                for (int i = 0; i < keyColliders.Length; i++)
                {
                    keyColliders[i].enabled = false;
                }
                door.transform.position = new Vector3(0,2,0);

            }
            else
            {
                m_Object.text = "Locked";
                keyVal = null;
                keyCount = 0;
            }
        }
    }
}
