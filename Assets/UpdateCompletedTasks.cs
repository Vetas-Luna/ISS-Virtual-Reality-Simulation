using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateCompletedTasks : MonoBehaviour
{
    private TMP_InputField tMP_Input;
    string mystring = "Hello!!";

    // Start is called before the first frame update
    void Start()
    {
        tMP_Input = gameObject.GetComponent<TMP_InputField>();
        tMP_Input.text = mystring;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
