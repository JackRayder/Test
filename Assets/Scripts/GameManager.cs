using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Test
{
    public class GameManager : MonoBehaviour
    {
        public GameObject CellPref;
        public Transform Parent;
        public List<Sprite> CellLetters;
        public List<Sprite> CellNumbers;
        public List<Sprite> NumbersSpare;
        public List<Sprite> LettersSpare;
        private int CellNumber = 0;
        public GameManager _gameManager;
        public GameObject _reset;
        public int WinNumber;
        public int Set;
        public bool isRoundOne = true;
        public bool isRoundTwo = false;
        public bool isRoundThree = false;


        private void Start()
        {
            NumbersSpare = new List<Sprite>(CellNumbers);
            LettersSpare = new List<Sprite>(CellLetters);
            Round1();
        }

        public void Round1()
        {
            Set = Random.Range(1, 3);

            WinNumber = Random.Range(1, 4);
            int i = 0;
            while (i++ < 3)
                Create(Set);
        }
        public void Round2()
        {
            Set = Random.Range(1, 3);
            WinNumber = Random.Range(1, 7);
            int i = 0;
            while (i++ < 6)
                Create(Set);
        }
        public void Round3()
        {
            Set = Random.Range(1, 3);
            WinNumber = Random.Range(1, 10);
            int i = 0;
            while (i++ < 9)
                Create(Set);
        }

        public void ClearField(int set)
        {
            CellNumber = 0;
            GameObject[] clear = GameObject.FindGameObjectsWithTag("Cell");
            for (int i = 0; i < clear.Length; i++)
            {
                if (clear == null) return;
                Destroy(clear[i]);
            }
            CellNumbers = new List<Sprite>(NumbersSpare);
            CellLetters = new List<Sprite>(LettersSpare);

        }
        private void Create(int set)
        {
            CellNumber++;
            GameObject NewCell = Instantiate(CellPref, Parent, false);
            NewCell.GetComponent<Cell>().CellNumber = CellNumber;
            NewCell.GetComponent<Cell>()._gameManager = _gameManager;
            NewCell.GetComponent<Cell>().ResetButton = _reset;

            if (set == 1) 
            {
                int randomImage = Random.Range(0, CellLetters.Count);
                NewCell.GetComponent<Image>().sprite = CellLetters[randomImage];
                CellLetters.RemoveAt(randomImage);
            }

            if (set == 2)
            {
                int randomImage = Random.Range(0, CellNumbers.Count);
                NewCell.GetComponent<Image>().sprite = CellNumbers[randomImage];
                CellNumbers.RemoveAt(randomImage);
            }
        }
        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
