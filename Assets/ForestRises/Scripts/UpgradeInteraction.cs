using UnityEngine;

namespace ForestRises
{
    public class UpgradeInteraction : MonoBehaviour
    {
        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
            {
                UpgradesManager.Instance.Suggest();
                Destroy(gameObject);
            }
        }
    }
}