using UnityEngine;

public class RocketEnergySystem : MonoBehaviour
{
    private float fuel;
    private float maxFuel;

    private readonly float SPEED = 5f;
    private readonly float FUELPERSHOOT = 10f;

    public void Shoot(Rigidbody2D _rb2d)
    {
        // TODO : fuel이 넉넉하면 윗 방향으로 SPEED만큼의 힘으로 점프, 모자라면 무시
        if (fuel > FUELPERSHOOT)
        {
            Vector2 shootSpeed = new Vector2(0, SPEED);
            _rb2d.AddForce(shootSpeed, ForceMode2D.Impulse);
            fuel -= FUELPERSHOOT;
        }
    }

    public void FuelCharging()
    {
        if (maxFuel > fuel)
        {
            fuel += 0.1f;
        }
        else
        {
            fuel = maxFuel;
        }
    }

    public float GetFuel()
    {
        return fuel;
    }

    public void SetMaxFuel(float MaxFuel)
    {
        maxFuel = MaxFuel;
        fuel = maxFuel;
    }
}