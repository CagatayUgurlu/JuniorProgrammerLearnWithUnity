using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 5);
        transform.localScale = Vector3.one * 2f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 2f, 2f);
    }
    
    void Update()
    {
        transform.Rotate(15.0f * Time.deltaTime , 0.1f, 0.1f);
    }
}
