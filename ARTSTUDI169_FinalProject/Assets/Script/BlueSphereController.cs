using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSphereController : MonoBehaviour
{
    public bool isBlue;
    // Start is called before the first frame update
    void Start()
    {
        isBlue = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "blueAltar")
        {
            isBlue = true;
        }
    }
}