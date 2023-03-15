using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkEffect : MonoBehaviour
{
    public GameObject item;
    public Material highlightColor;

    Material itemColor;
    MeshRenderer itemMeshRenderer;

    readonly float duration = 1f;
    private bool pingpong;

    // Start is called before the first frame update
    void Start()
    {
        itemMeshRenderer = item.GetComponent<MeshRenderer>();
        itemColor = new Material(itemMeshRenderer.material);
        pingpong = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pingpong){
            float lerp = Mathf.PingPong(Time.time, duration) / duration;
            itemMeshRenderer.material.Lerp(itemColor, highlightColor, lerp);
        }
    }

    public void PingPongMaterial(){
        pingpong = !pingpong;
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log(other.tag);
        if(!(other.CompareTag("Table"))){
            pingpong = false;
            itemMeshRenderer.material = itemColor;
        }
    }


}
