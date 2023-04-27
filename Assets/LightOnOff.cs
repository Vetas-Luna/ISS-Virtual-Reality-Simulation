using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class LightOnOff : MonoBehaviour

{
    public GameObject txtToDisplay;             //display the UI text
    private bool PlayerInZone;                  //check if the player is in trigger
    public GameObject lightorobj;

    public GameObject task;
    public GameObject prevText;
    public GameObject newText;
    public GameObject prevButton;
    public GameObject newButton;

    public GameObject newPlant;
    public GameObject dirtMound;

    private void Start()
    {
        PlayerInZone = false;                   //player not in zone       
        txtToDisplay.SetActive(false);
    }

    private void Update()
    {
        if (PlayerInZone && task.activeSelf == true)           //if in zone and press F key
        {
            lightorobj.SetActive(true);
            gameObject.GetComponent<Animator>().Play("switch");

            if(dirtMound.activeSelf){
                ShowExplanation();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")     //if player in zone
        {
            Debug.Log("player in zone");
            txtToDisplay.SetActive(true);
            PlayerInZone = true;
        }
     }

    private void OnTriggerExit(Collider other)     //if player exit zone
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInZone = false;
            txtToDisplay.SetActive(false);
        }
    }

    private void ShowExplanation(){
        if(task.activeSelf == true){
                prevText.SetActive(false);
                newText.SetActive(true);
                prevButton.SetActive(false);
                newButton.SetActive(true);
                GrowPlant();
            }
    }

    private void GrowPlant(){
        dirtMound.SetActive(false);
        newPlant.SetActive(true);
    }
}