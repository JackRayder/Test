using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test
{
    public class Cell : MonoBehaviour
    {
        public int CellNumber;
        public GameManager _gameManager;
        public GameObject ResetButton;
        public void Check()
        {
            if (_gameManager.isRoundOne && CellNumber == _gameManager._round1.WinNumber)
            {
                _gameManager.isRoundOne = false;
                _gameManager.isRoundTwo = true;
                _gameManager._clearField.Clear(_gameManager);
                _gameManager._round2.Round(_gameManager);
            }
            if (_gameManager.isRoundTwo && CellNumber == _gameManager._round2.WinNumber)
            {
                _gameManager.isRoundTwo = false;
                _gameManager.isRoundThree = true;
                _gameManager._clearField.Clear(_gameManager);
                _gameManager._round3.Round(_gameManager);
            }
            if (_gameManager.isRoundThree && CellNumber == _gameManager._round3.WinNumber)
            {
                ResetButton.SetActive(true);
                _gameManager.isRoundThree = false;
                _gameManager._clearField.Clear(_gameManager);

            }
        }
    }
}