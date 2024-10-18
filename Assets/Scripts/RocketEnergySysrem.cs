using UnityEngine;
using UnityEngine.UI;

public class RocketEnergySysrem : MonoBehaviour
{
    public float fuel = 100f;
    public float fuelMax = 100f;

    [SerializeField] private Image fuelBarFront;

    private void Start()
    {
        CheckFuel();
    }

    private void Update()
    {
        ChargeFuel();
    }

    private void ChargeFuel()
    {
        if (fuel < fuelMax) fuel += 0.1f;
        CheckFuel();
    }

    public void CheckFuel()
    {
        float leftFuel = fuel / fuelMax;

        fuelBarFront.fillAmount = leftFuel;
    }
}