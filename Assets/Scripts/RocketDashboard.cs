using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RocketDashboard : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI currentScoreTxt;
    [SerializeField] private TextMeshProUGUI highScoreTxt;
    [SerializeField] private Image FuelImg;

    int currentScore;
    int hightScore;

    public void HightScore()
    {
        currentScore = (int)transform.position.y;
        if (currentScore >= hightScore)
        {
            hightScore = currentScore;
        }
        currentScoreTxt.text = $"{currentScore} M";
        highScoreTxt.text = $"HIGH : {hightScore} M";
    }
    public void Fuel(float Min, float Max, float Fuel)
    {
        FuelImg.fillAmount = (Fuel - Min) / (Max - Min);
    }
}
