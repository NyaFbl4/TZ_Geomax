using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ForestRises
{
    public class UpgradesManager : MonoBehaviour
    {
        [SerializeField] private UpgradesUiManager _uiManager;
        [SerializeField] private Inventory _inventory;
        
        [SerializeField] private List<Upgrade> _upgrades;

        private List<Upgrade> _avalibleUpgrades;

        public static UpgradesManager Instance { get; private set; }
        
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject); 
            }
            else
            {
                Destroy(gameObject);
            }
            
            _avalibleUpgrades = _upgrades.ToList();
        }

        public void Suggest()
        {
            if (_avalibleUpgrades.Count > 0)
            {
                Time.timeScale = 0;
                _uiManager.Show(_avalibleUpgrades);
            }
        }

        public void OnUpgradeApplied(Upgrade appliedUpgrade)
        {
            _uiManager.Hide();
            _inventory.AddUpgrade(appliedUpgrade);

            Time.timeScale = 1;
        }
    }
}