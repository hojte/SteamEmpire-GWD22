using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CrowFlying : MonoBehaviour
{
    [SerializeField] float flyHeight = 50;
    [SerializeField] float flyRadius = 30;
    [SerializeField] float rotSpeed = 5;
    [SerializeField] float flySpeed = 10;
    Animator anim;
    Vector3 targetPos;
    bool isFlying = false;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (isFlying)
        {
            Vector3 _targetDir = targetPos - transform.position;
            Vector3 _newDir = Vector3.RotateTowards(transform.forward, _targetDir, Time.deltaTime * rotSpeed, 0);
            transform.rotation = Quaternion.LookRotation(_newDir);
            transform.Translate(Vector3.forward * Time.deltaTime * flySpeed);
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            targetPos = transform.position + new Vector3(Random.Range(-flyRadius, flyRadius), flyHeight, Random.Range(-flyRadius, flyRadius));
            isFlying = true;
            anim.SetBool("Flying", true);
        }
    }
}
