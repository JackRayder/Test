using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Test
{
    public class ClearField : MonoBehaviour
    {
        public void Clear(GameManager _gameManager)
        {
            _gameManager._createCell.CellNumber = 0;
            GameObject[] clear = GameObject.FindGameObjectsWithTag("Cell");
            for (int i = 0; i < clear.Length; i++)
            {
                if (clear == null) return;
                Destroy(clear[i]);
            }

        }
    }
}