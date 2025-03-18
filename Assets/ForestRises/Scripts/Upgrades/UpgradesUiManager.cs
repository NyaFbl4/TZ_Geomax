using System.Collections.Generic;
using UnityEngine;

namespace ForestRises
{
    public class UpgradesUiManager : MonoBehaviour
    {
        [SerializeField] private UpgradeUi _upgradeUiPrefab;

        public void Show(List<Upgrade> upgrades)
        {
            gameObject.SetActive(true);

            foreach (Transform child in transform)
            {
                Destroy(child.gameObject);
            }
            
            foreach (var upgrade in upgrades)
            {
                var ui = Instantiate(_upgradeUiPrefab, transform);
                ui.Setup(upgrade.Title, () => OnClickApply(upgrade));
            }
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        private void OnClickApply(Upgrade upgrade)
        {
            upgrade.Apply();
            UpgradesManager.Instance.OnUpgradeApplied(upgrade);
        }
    }
}