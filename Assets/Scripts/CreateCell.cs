using System.Collections;
using System.Collections.Generic;
using UnityEditor.Presets;
using UnityEngine;
using UnityEngine.UI;

namespace Test
{
    public class CreateCell : MonoBehaviour
    {
        public int CellNumber = 0;

        public void Create(GameManager _gameManager, int set, List<Sprite> Letters, List<Sprite> Numbers)
        {
            GameObject NewCell = Instantiate(_gameManager._cellPref, _gameManager._parent, false);

            if (set == 1)
            {
                int randomImage = Random.Range(0, Letters.Count);
                NewCell.GetComponent<Image>().sprite = Letters[randomImage];
                NewCell.GetComponent<Initialization>().CheckValue(set, NewCell.GetComponent<Image>().sprite.name);
                Letters.RemoveAt(randomImage);
            }

            if (set == 2)
            {
                int randomImage = Random.Range(0, Numbers.Count);
                NewCell.GetComponent<Image>().sprite = Numbers[randomImage];
                NewCell.GetComponent<Initialization>().CheckValue(set, NewCell.GetComponent<Image>().sprite.name);
                Numbers.RemoveAt(randomImage);
            }
            CellNumber++;
            NewCell.GetComponent<Cell>().CellNumber = CellNumber;
            NewCell.GetComponent<Cell>()._gameManager = _gameManager;
            NewCell.GetComponent<Cell>().ResetButton = _gameManager._reset;
        }
    }
}