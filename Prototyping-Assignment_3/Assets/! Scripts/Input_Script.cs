using System;
using Unity.VisualScripting;
using UnityEngine;

public class Input_Script : MonoBehaviour
{
    [SerializeField] private Start_Script start_Script;
    
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
            print("block top left");
        }// end Block TL Input
        
        // Bottom Left pad linked to S input
        else if (Input.GetKey(KeyCode.S))
        {
            print("block bottom left");
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
            print("block bottom right");
        }// end Block BR Input
        
        // Top Right pad linked to G input
        else if (Input.GetKey(KeyCode.G))
        {
            print("block top right");
        }// end Block TR Input
        
    }// end Update()
    
}// end script
