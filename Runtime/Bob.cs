using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bob : MonoBehaviour
{

    public Button but = null;
    public string value = "Bob";
    // Start is called before the first frame update
    void Start()
    {
        if(!but)
        {
            but = GetComponent<Button>();
        }
        if (but)
        {
            Text t = GetComponentInChildren<Text>();
            t.text = value;
        }
    }

}
