using System;
using UnityEngine;

public class Input_Script : MonoBehaviour
{
    public bool Attack_Window = false;
    
    private void Update()
    {
        // Top Left pad linked to A input
        if (Input.GetKeyDown(KeyCode.A))
        {
            print("block top left");
        }// end Block TL Input
        
        // Bottom Left pad linked to S input
        else if (Input.GetKeyDown(KeyCode.S))
        {
            print("block bottom left");
        }// end Block BL Input
        
        // Attack input linked to D input
        else if (Input.GetKeyDown(KeyCode.D))
        {
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
        else if (Input.GetKeyDown(KeyCode.F))
        {
            print("block bottom right");
        }// end Block BR Input
        
        // Top Right pad linked to G input
        else if (Input.GetKeyDown(KeyCode.G))
        {
            print("block top right");
        }// end Block TR Input
        
    }// end Update()
    
}// end script
