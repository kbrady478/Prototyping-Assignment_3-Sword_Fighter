using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Input_Script : MonoBehaviour
{
    [SerializeField] private Start_Script start_Script;
    [SerializeField] private Timing_Manager timing_Manager;
    [SerializeField] private Score_Manager score_Manager;
    [SerializeField] private Enemy_Script enemy_Script;
    
    public bool player_Can_Input = true;
    public bool Attack_Window = false;

    private void Start()
    {
        player_Can_Input = true;
    }
    
    private void Update()
    {
        if (player_Can_Input == false)
            return;
        
        // Top Left pad linked to A input
        if (Input.GetKey(KeyCode.A))
        {
            if (enemy_Script.attack_Value != 0)
                return;
            
            print("block top left");
            timing_Manager.Player_Blocked();
        }// end Block TL Input
        
        // Bottom Left pad linked to S input
        else if (Input.GetKey(KeyCode.S))
        {
            if (enemy_Script.attack_Value != 1)
                return;
            
            print("block bottom left");
            timing_Manager.Player_Blocked();
        }// end Block BL Input
        
        // Attack input linked to D input
        else if (Input.GetKey(KeyCode.D))
        {
            if (start_Script.has_Started == false)
            {
                start_Script.has_Started = true;
                start_Script.Start_Game();
                return;
            }
            
            // check attack window
            if (Attack_Window == true)
            {
                Attack_Window = false;
                score_Manager.Update_Score();
                print("attack success");
            }

            else
            {
                print("attack failed");
            }
            
        }// end Attack input
        
        // Bottom Right pad linked to F input
        else if (Input.GetKey(KeyCode.F))
        {
            if (enemy_Script.attack_Value != 3)
                return;
            
            print("block bottom right");
            timing_Manager.Player_Blocked();
        }// end Block BR Input
        
        // Top Right pad linked to G input
        else if (Input.GetKey(KeyCode.G))
        {
            if (enemy_Script.attack_Value != 2)
                return;
            
            print("block top right");
            timing_Manager.Player_Blocked();
        }// end Block TR Input
        
    }// end Update()
    
}// end script
