using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowSphereController : MonoBehaviour
{
    public bool isYellow;
    // Start is called before the first frame update
    void Start()
    {
        isYellow = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "yellowAltar")
        {
            isYellow = true;
        }
    }
}