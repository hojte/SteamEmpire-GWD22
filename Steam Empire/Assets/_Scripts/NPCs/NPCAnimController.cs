using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class NPCAnimController : MonoBehaviour
{
    enum Animations { WashingClothes, Talking, Crying, Begging, Puking, ArmsCrossed, Writing, FixingCart}
    [SerializeField] Animations animations;

    Animator anim;

    void Start()
    {

        anim.Play(0, -1, Random.value);
    }


    void Awake()
    {
        anim = GetComponent<Animator>();
        anim.SetFloat("AnimIndex", (int)animations);
        transform.rotation = Quaternion.Euler(90, transform.rotation.eulerAngles.y, 0);
        
    }
}
