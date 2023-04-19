using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantSeed : MonoBehaviour
{
    public GameObject seedPacket;
    public GameObject dirtMound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowSeedMound(){
        dirtMound.SetActive(true);
        seedPacket.SetActive(false);
    }

}
