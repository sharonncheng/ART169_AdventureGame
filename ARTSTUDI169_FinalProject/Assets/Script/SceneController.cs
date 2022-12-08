using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public SphereController red;
    public YellowSphereController yellow;
    public BlueSphereController blue;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (red.isRed && yellow.isYellow && blue.isBlue)
        {
            SceneManager.LoadScene("FinalScene");
        }
    }

}
