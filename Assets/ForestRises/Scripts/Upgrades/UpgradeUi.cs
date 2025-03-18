using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ForestRises
{
    public class UpgradeUi : MonoBehaviour
    {
        [SerializeField] private TMP_Text _title;

        private Action applyAction;
        
        public void Setup(string title, Action onApply)
        {
            _title.text = title;
            applyAction = onApply;
        }

        public void Apply()
        {
            applyAction?.Invoke();
        }
    }
}