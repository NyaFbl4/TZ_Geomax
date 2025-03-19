using System;
using UnityEngine;

namespace ForestRises
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private InputSystem _inputSystem;
        [SerializeField] private Rigidbody _rigidbody;
        
        private float _dirX = 0;
        private float _dirZ = 0;
        
        private GameObject _upgradeInteraction;

        private void Awake()
        {
            _inputSystem.OnMoveX += OnMoveX;
            _inputSystem.OnMoveZ += OnMoveZ;
        }

        private void Update()
        {
            Vector3 direction = new Vector3(_dirX, 0, _dirZ).normalized;

            _rigidbody.velocity = direction * PlayerStats.Instance.Speed;
            
            if (_upgradeInteraction != null)
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

        private void OnMoveX(float directionX)
        {
            _dirX = directionX;
            //Debug.Log(_dirX);
        }
        
        private void OnMoveZ(float directionZ)
        {
            _dirZ = directionZ;
            //Debug.Log(_dirZ);
        }
    }
}