using System;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [SerializeField] private int max_HP = 3;
    public int current_HP;

    private void Start()
    {
        current_HP = max_HP;
    }// end Start()

    public void Take_Damage()
    {
        current_HP--;

        if (current_HP == 0)
        {
            print("you lose");
        }
    }// end Take_Damage()
    
}// end script
