using UnityEngine;

namespace ForestRises
{
    public class HealthUpgrade : Upgrade
    {
        [SerializeField] private int _health;
        
        public override void Apply()
        {
            PlayerStats.Instance.ApplyHealthBoost(_health);
        }
    }
}