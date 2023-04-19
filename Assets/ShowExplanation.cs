using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowExplanation : MonoBehaviour
{
    public GameObject task;
    public GameObject prevText;
    public GameObject newText;
    public GameObject prevButton;
    public GameObject newButton;
    public GameObject item;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == item.tag){
            if(task.activeSelf == true){
                prevText.SetActive(false);
                newText.SetActive(true);
                prevButton.SetActive(false);
                newButton.SetActive(true);
            }
        }
    }
}