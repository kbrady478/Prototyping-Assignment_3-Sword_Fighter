using UnityEngine;

public class Start_Script : MonoBehaviour
{
    [SerializeField] private GameObject startScreen;
    [SerializeField] private Enemy_Script enemy_Script;
    public bool has_Started = false;

    public void Start_Game()
    {
        print("Game Started");
        startScreen.SetActive(false);
        enemy_Script.Idle_State();
        
    }// end start_Game()
    
}// end script
