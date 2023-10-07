using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;

public class Game
{
    #region Fields
    private List<int> _highscores = new List<int>();
    private Dice _dice1;
    private Dice _dice2;
    #endregion

    #region Properties
    public int Eye1 => _dice1.Dots;
    public int Eye2 => _dice2.Dots;
    public bool HasSnakeEyes { get; set; }
    public IReadOnlyList<int> HighScores => _highscores.AsReadOnly();
    public int Total { get; set; }
    #endregion

    #region Constructors
    public Game()
    {
        Initialize();
    }
    #endregion

    #region Methods
    private void Initialize()
    {
        _dice1 = new Dice();
        _dice2 = new Dice();
        HasSnakeEyes = false;
    }

    public void Play()
    {
        _dice1.Roll();
        _dice2.Roll();
     
        if (Eye1 == 1 && Eye2 == 1)
        {
            HasSnakeEyes = true;
            _highscores.Add(Total);
            Total = 0;
        } else
        {
            Total += Eye1 + Eye2;
        }
    }

    public void Restart()
    {
        Initialize();
        Play();
    }
    #endregion
}
