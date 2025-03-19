using System;
using UnityEngine;

namespace ForestRises
{
    public class InputSystem : MonoBehaviour
    {
        public event Action<float> OnMoveX;
        public event Action<float> OnMoveZ;

        public void Update()
        {
            float directionX = 0;
            
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                directionX = -1;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                directionX = 1;
            }
            else
            {
                directionX = 0;
            }
            
            float directionZ = 0;
            
            if (Input.GetKey(KeyCode.UpArrow))
            {
                directionZ = 1;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                directionZ = -1;
            }
            else
            {
                directionZ = 0;
            }

            OnMoveX?.Invoke(directionX);
            OnMoveZ?.Invoke(directionZ);
        }
    }
}