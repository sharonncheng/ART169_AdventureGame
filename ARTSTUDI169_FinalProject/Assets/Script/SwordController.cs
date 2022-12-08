using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour
{
    public GameObject monster;
    public GameObject gate;
    public GameObject wizard;
    public GameObject sphere;
    public GameObject floor;
    private bool wizardSafe;
    private int delay;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = wizard.GetComponentInChildren<Animator>();
        animator.SetBool("giveMagic", false);
        wizardSafe = false;
        sphere.SetActive(false);
        delay = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (wizardSafe)
        {
            animator.SetBool("giveMagic", true);
            StartCoroutine(WaitToSpawn());
            wizardSafe = false;
        }
    }

    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "grenade")
        {
            Debug.Log(collider.gameObject.name);
            monster.SetActive(false);
            gate.SetActive(false);
            wizardSafe = true;
        }
    }

    IEnumerator WaitToSpawn()
    {
        yield return new WaitForSeconds(delay);
        sphere.SetActive(true);

    }

}
