using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Rocket : MonoBehaviour
{
    [SerializeField] private float maxFuel = 100f;

    private Rigidbody2D _rb2d;
    RocketDashboard rocketDashboard;
    RocketEnergySystem rocketEnergySystem;

    void Awake()
    {
        // TODO : Rigidbody2D 컴포넌트를 가져옴(캐싱) 
        _rb2d = GetComponent<Rigidbody2D>();
        rocketDashboard = GetComponent<RocketDashboard>();
        rocketEnergySystem = GetComponent<RocketEnergySystem>();
        rocketEnergySystem.SetMaxFuel(maxFuel);
    }
    private void Update()
    {
        rocketEnergySystem.FuelCharging();
        rocketDashboard.Fuel(maxFuel, rocketEnergySystem.GetFuel());
        rocketDashboard.RocketUI();
    }
}
