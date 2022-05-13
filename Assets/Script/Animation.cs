using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    Animator DrunkWalking;
    public float speed;
    void Start()
    {
        DrunkWalking = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z <= 38)
        {
            DrunkWalking.GetComponent<Animator>().enabled = true;
            transform.position += Vector3.forward * Time.deltaTime * speed;
        }
        else
        {
            DrunkWalking.SetBool("Idle", true);
        }
    }
}
