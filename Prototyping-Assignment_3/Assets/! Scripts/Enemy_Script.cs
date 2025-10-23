using System;
using UnityEngine;
using System.Collections;
using Unity.VisualScripting;
using Random = UnityEngine.Random;

public class Enemy_Script : MonoBehaviour
{
    [SerializeField] private Timing_Manager timing_Manager_Script;
    [SerializeField] private Animator animator;
    public int attack_Value;
    
    public void Attack_State()
    {
        attack_Value = Random.Range(0, 4);
        print(attack_Value);
        Reset_Bools();
        
        switch (attack_Value)
        {
            case 0:
                print("Attacking from Top Left");
                animator.SetBool("Attack_Top_Left", true);
                break;
            
            case 1:
                print("Attacking from Bottom Left");
                animator.SetBool("Attack_Bottom_Left", true);
                break;
                
            case 2:
                print("Attacking from Top Right");
                animator.SetBool("Attack_Top_Right", true);
                break;
            
            case 3:
                print("Attacking from Bottom Right");
                animator.SetBool("Attack_Bottom_Right", true);
                break;
            
            default:
                print("ERROR: attack_Value invalid.");
                break;
        } // end switch
        
    }// end Attack_State()
    

    public void Attack_Landed()
    {
        timing_Manager_Script.Enemy_Attack_Landed();
    }// end  Attacked_Landed()

    public void Attack_Blocked()
    {
        Reset_Bools();
        
        animator.SetBool("Blocked", true);
    }// end Attack_Blocked()
    
    public void Vulnerable_State()
    {
        timing_Manager_Script.Enemy_Vulnerable();
    }// end Vulnerable_State()

    public void Idle_State()
    {
        Reset_Bools();
        animator.SetBool("Idle", true);
        timing_Manager_Script.Enemy_Idle();
    }// end Idle_State()
    
    private void Reset_Bools()
    {
        animator.SetBool("Blocked", false);
        animator.SetBool("Attack_Top_Left", false);
        animator.SetBool("Attack_Bottom_Left", false);
        animator.SetBool("Attack_Top_Right", false);
        animator.SetBool("Attack_Bottom_Right", false);
        animator.SetBool("Idle", false);
    }
}// end script
