using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Controller : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI hp_Text;
    [SerializeField] private int max_HP = 3;
    public int current_HP;

    private void Start()
    {
        current_HP = max_HP;
    }// end Start()

    public void Take_Damage()
    {
        current_HP--;
        hp_Text.text = current_HP.ToString();
        
        if (current_HP == 0)
        {
            print("you lose");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
        }
    }// end Take_Damage()
    
}// end script
