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
            if (_gameManager.isRoundOne && CellNumber == _gameManager.WinNumber)
            {
                _gameManager.isRoundOne = false;
                _gameManager.isRoundTwo = true;
                _gameManager.ClearField(_gameManager.Set);
               _gameManager.Round2();
            }
            if (_gameManager.isRoundTwo && CellNumber == _gameManager.WinNumber)
            {
                _gameManager.isRoundTwo = false;
                _gameManager.isRoundThree = true;
                _gameManager.ClearField(_gameManager.Set);
                _gameManager.Round3();

            }
            if (_gameManager.isRoundThree && CellNumber == _gameManager.WinNumber)
            {
                ResetButton.SetActive(true);
                _gameManager.isRoundThree = false;
                _gameManager.ClearField(_gameManager.Set);
            }
        }
    }
}