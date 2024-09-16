using UnityEngine;

public class ApplyUpgrade : MonoBehaviour
{
    public Upgrade upgrade;
    public GameObject player;

    public void Apply()
    {
        upgrade.Apply(player);
    }
}
