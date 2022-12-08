using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    public bool isRed;
    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        isRed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "redAltar")
        {
            isRed = true;
        }
    }
}
