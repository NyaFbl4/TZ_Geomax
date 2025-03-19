using System;
using UnityEngine;

namespace ForestRises
{
    public class PlayerStats : MonoBehaviour
    {
        [SerializeField] private int _health;
        [SerializeField] private float _speed;
        [SerializeField] private int _damage;

        public int Health => _health;
        public int Damage => _damage;
        public float Speed => _speed;
        
        public static PlayerStats Instance { get; private set; }
        
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
        }

        public void ApplyHealthBoost(float percent)
        {
            _health = CalculateNewValue(_health, percent);
            Debug.Log($"New Health: {PlayerStats.Instance._health}");
        }

        public void ApplySpeedBoost(float percent)
        {
            _speed = CalculateNewValue(_speed, percent);
            Debug.Log($"New Speed: {PlayerStats.Instance._speed}");
        }

        public void ApplyDamageBoost(float percent)
        {
            _damage = CalculateNewValue(_damage, percent);
            Debug.Log($"New Damage: {PlayerStats.Instance._damage}");
        }

        public T CalculateNewValue<T>(T oldValue, float percentageIncrease) where T : struct, IConvertible
        {
            if (percentageIncrease < 0)
            {
                return oldValue;
            }

            float oldValueFloat = Convert.ToSingle(oldValue);
            float newValueFloat = oldValueFloat + (oldValueFloat * (percentageIncrease / 100f));
            
            return (T)Convert.ChangeType(newValueFloat, typeof(T));
        }
    }
}
