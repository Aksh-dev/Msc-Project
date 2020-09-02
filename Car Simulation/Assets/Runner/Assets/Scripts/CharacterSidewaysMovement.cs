using UnityEngine;
using Assets.Scripts;
using UnityEngine.SceneManagement;
using System.Collections;

public class CharacterSidewaysMovement : MonoBehaviour
{
    private CharacterController controller;
    private Animator anim;

    public Transform CharacterGO;
    
    void Start()
    {
     
        anim = CharacterGO.GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        anim.SetBool(Constants.AnimationStarted, true);

    }


    }



