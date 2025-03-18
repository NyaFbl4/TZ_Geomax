using UnityEngine;

namespace ForestRises
{
    public class SpeedUpgrade : Upgrade
    {
        [SerializeField] private float _speed;

        public override void Apply()
        {
            PlayerStats.Instance.ApplySpeedBoost(_speed);
        }
    }
}