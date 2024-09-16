using UnityEngine;

[CreateAssetMenu(fileName = "VisualUpgrade", menuName = "Scriptable Objects/VisualUpgrade")]
public class VisualUpgrade : Upgrade
{
    public Sprite newSprite;

    public override void Apply(GameObject player)
    {
        player.GetComponent<SpriteRenderer>().sprite = newSprite;
    }
}
