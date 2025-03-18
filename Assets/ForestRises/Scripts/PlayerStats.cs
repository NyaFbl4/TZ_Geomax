using UnityEngine;

namespace ForestRises
{
    public class PlayerStats : MonoBehaviour
    {
        [SerializeField] private int _health;
        [SerializeField] private float _speed;
        [SerializeField] private int _damage;
        
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

        public void ApplyHealthBoost(int amount)
        {
            _health += amount;
            Debug.Log($"New Health: {PlayerStats.Instance._health}");
        }

        public void ApplySpeedBoost(float amount)
        {
            _speed += amount;
            Debug.Log($"New Speed: {PlayerStats.Instance._speed}");
        }

        public void ApplyDamageBoost(int amount)
        {
            _damage += amount;
            Debug.Log($"New Damage: {PlayerStats.Instance._damage}");
        }
    }
}
