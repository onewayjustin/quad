using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quad : MonoBehaviour
{
    // Start is called before the first frame update
    public float scrollingspeed;
    public bool scrolling;
    Material backaroundMaterial;
    private void Awake(){
         backaroundMaterial = GetComponent<Renderer>().material;
    }
    void Start()
    {
        
        Debug.Log("it worked");
        
    }
    private void FixedUpdate(){
        if(scrolling){
            Vector2 offset = new Vector2(scrollingspeed * Time.time,0);
            backaroundMaterial.mainTextureOffset= offset;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
