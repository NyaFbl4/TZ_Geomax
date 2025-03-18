using UnityEngine;

namespace ForestRises
{
    public class DamageUpgrade : Upgrade
    {
        [SerializeField] private int _damage;
        
        public override void Apply()
        {
            PlayerStats.Instance.ApplyDamageBoost(_damage);
        }
    }
}