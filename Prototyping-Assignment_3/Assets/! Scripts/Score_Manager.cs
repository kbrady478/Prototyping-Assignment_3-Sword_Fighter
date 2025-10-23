using TMPro;
using UnityEngine;

public class Score_Manager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI score_Text;
    private int score = 0;
    
    public void Update_Score()
    {
        score += 10;
        score_Text.text = score.ToString();
    }// end Update_Score()
    
}// end script
