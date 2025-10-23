using UnityEngine;

public class Timing_Manager : MonoBehaviour
{
    [SerializeField] private Input_Script input_Script;
    [SerializeField] private Player_Controller player_Controller_Script;
    [SerializeField] private Enemy_Script enemy_Script;
    [SerializeField] private float time_Scaler; // how much the game slows down or speeds up by
    

    public void Enemy_Starts_Attack()
    {
        print("enemy attacking");
        Time.timeScale = time_Scaler;
        input_Script.player_Can_Input = true;
        enemy_Script.Attack_State();
    }// end Enemy_Starts_Attack()

    public void Enemy_Attack_Landed()
    {
        print("enemy attack landed");
        Time.timeScale = 1;
        input_Script.player_Can_Input = false;
        enemy_Script.Idle_State();
    }// end Enemy_Attack_Landed()

    public void Enemy_Vulnerable()
    {
        print("enemy vulnerable");
        Time.timeScale = time_Scaler;
        input_Script.Attack_Window = true;

    }// end Timescale_Triggered()

    public void Enemy_Idle()
    {
        print("enemy idle");
        Time.timeScale = 1;
        input_Script.player_Can_Input = false;
        float idle_Time = Random.Range(0.8f, 2.5f);
        Invoke(nameof(Enemy_Starts_Attack), idle_Time);
        
    }// end Enemy_Idle()
    
    
    
}// end script
