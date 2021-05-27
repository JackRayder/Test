using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Test
{
    public class GameManager : MonoBehaviour
    {
        public Text _task;
        public List<Sprite> CellLetters;
        public List<Sprite> CellNumbers;
        public ClearField _clearField;
        public CreateCell _createCell;
        public GameManager _gameManager;
        public Round1 _round1;
        public Round2 _round2;
        public Round3 _round3;
        public GameObject _cellPref;
        public Transform _parent;
        public GameObject _reset;
        public bool isRoundOne = true;
        public bool isRoundTwo = false;
        public bool isRoundThree = false;


        private void Start()
        {
            _round1.Round(_gameManager);
        }
        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void Task(string value)
        {
            _task.text = "Find " + value;
        }
    }
}
