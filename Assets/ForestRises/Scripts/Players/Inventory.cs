using System.Collections.Generic;
using UnityEngine;

namespace ForestRises
{
    public class Inventory : MonoBehaviour
    {
        [SerializeField] private List<Upgrade> _upgrades = new();

        public void AddUpgrade(Upgrade upgrade)
        {
            _upgrades.Add(upgrade);
        }
    }
}