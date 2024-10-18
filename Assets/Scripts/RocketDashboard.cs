using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RocketDashboard : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currentScoreTxt;
    [SerializeField] private TextMeshProUGUI highScoreTxt;
    [SerializeField] private Image FuelImg;

    int currentScore;
    int hightScore;

    float max;
    public float fuel;

    public void RocketUI()
    {
        HightScore();
        FuelUI();
    }

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

    public void Fuel(float Max, float Fuel)
    {
        max = Max;
        fuel = Fuel;
    }

    public void FuelUI()
    {
        FuelImg.fillAmount = fuel / max;
    }

    public void ReStartGame()
    {
        SceneManager.LoadScene("RocketLauncher");
    }
}
