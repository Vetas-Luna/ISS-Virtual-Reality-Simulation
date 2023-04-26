using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkEffect : MonoBehaviour
{
    public GameObject item;
    public Material highlightItemMaterial;

    MeshRenderer itemMeshRenderer;
    public Material itemMaterial;

    readonly float duration = 1f;
    private bool pingpong = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Active!");
       itemMeshRenderer = item.GetComponent<MeshRenderer>();
       //itemMaterial = new Material(itemMeshRenderer.material); 
    }

    // Update is called once per frame
    void Update()
    {
        if(pingpong){
            float lerp = Mathf.PingPong(Time.time, duration) / duration;
            itemMeshRenderer.material.Lerp(itemMaterial, highlightItemMaterial, lerp);
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(!(other.gameObject.CompareTag("Work Table"))){
            pingpong = false;
            if(itemMeshRenderer != null){
                itemMeshRenderer.material = itemMaterial;
            }
        }
    }

}
