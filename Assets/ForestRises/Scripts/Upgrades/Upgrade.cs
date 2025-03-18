using UnityEngine;

namespace ForestRises
{
    public abstract class Upgrade : MonoBehaviour
    {
        [SerializeField] private string _title;

        public string Title => _title;
        
        public abstract void Apply();
    }
}