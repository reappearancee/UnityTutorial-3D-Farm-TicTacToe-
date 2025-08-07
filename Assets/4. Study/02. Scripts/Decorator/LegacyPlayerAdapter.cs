using UnityEngine;

public class LegacyPlayerAdapter : MonoBehaviour
{
    private LegacyPlayer _legacyPlayer;

    void Awake()
    {
        _legacyPlayer = new LegacyPlayer();
    }

    public void Move(Vector3 dir)
    {
        _legacyPlayer.LegacyMove(dir.x, dir.y, dir.z);
    }

    public void Attack()
    {
        _legacyPlayer.LegacyAttack();
    }
}