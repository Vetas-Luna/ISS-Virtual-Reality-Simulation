using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiFollow : MonoBehaviour
{
    public GameObject looker;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.tag == "MainCamera")
        {
            looker.SetActive(true);
        }
    }

    void OnTriggerStay(Collider other)
    {
        
        if (other.tag == "MainCamera") { 
            looker.transform.LookAt(other.transform);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            looker.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
