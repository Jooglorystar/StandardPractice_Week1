using UnityEngine;
using UnityEngine.UI;

public class Rocket : MonoBehaviour
{
    private Rigidbody2D _rb2d;
    private RocketEnergySysrem energySystem;

    private readonly float SPEED = 5f;
    private readonly float FUELPERSHOOT = 10f;

    [SerializeField] private Button shootButton;

    void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        energySystem = GetComponent<RocketEnergySysrem>();
    }

    public void Shoot()
    {
        if (energySystem.fuel >= FUELPERSHOOT)
        {
            _rb2d.velocity = Vector3.up * SPEED;
            energySystem.fuel -= FUELPERSHOOT;
        }
        energySystem.CheckFuel();
    }
}
