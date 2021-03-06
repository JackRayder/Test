using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test
{
    public class Round1 : MonoBehaviour
    {
        public int Set;
        public int WinNumber;

        public void Round(GameManager gameManager)
        {

            List<Sprite> Letters = new List<Sprite>(gameManager.CellLetters);
            List<Sprite> Numbers = new List<Sprite>(gameManager.CellNumbers);

            Set = Random.Range(1, 3);

            WinNumber = Random.Range(1, 4);
            int i = 0;
            while (i++ < 3)
                gameManager._createCell.Create(gameManager, Set, Letters, Numbers);

            GameObject[] cells = GameObject.FindGameObjectsWithTag("Cell");

            for (int q = 0; q < cells.Length; q++)
            {
                if (WinNumber == cells[q].GetComponent<Cell>().CellNumber) gameManager.Task(cells[q].GetComponent<Initialization>().value);
            }
        }
    }
}