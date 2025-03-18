using System;
using UnityEngine;

namespace ForestRises
{
    public class PlayerController : MonoBehaviour
    {
        private GameObject _upgradeInteraction;

        private void Update()
        {
            if (_upgradeInteraction != null && Input.GetKeyDown(KeyCode.E))
            {
                UpgradesManager.Instance.Suggest();
                Destroy(_upgradeInteraction);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("UpgradeInteraction"))
            {
                _upgradeInteraction = other.gameObject;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("UpgradeInteraction"))
            {
                _upgradeInteraction = null;
            }
        }
    }
}