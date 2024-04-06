using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    public float speed;
    [SerializeField]
    private Renderer renderer;


    // Update is called once per frame
    void Update()
    {
        renderer.material.mainTextureOffset  += new Vector2(0, speed * Time.deltaTime);
    }
}
