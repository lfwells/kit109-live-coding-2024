using UnityEngine;

[CreateAssetMenu(fileName = "ShootingUpgrade", menuName = "Scriptable Objects/ShootingUpgrade")]
public class ShootingUpgrade : Upgrade
{
    public float percentageIncrease = 0.1f;

    public override void Apply(GameObject player)
    {
        PlayerShooting playerShooting = player.GetComponent<PlayerShooting>();
        playerShooting.fireRate *= 1 + percentageIncrease;
    }    
}
