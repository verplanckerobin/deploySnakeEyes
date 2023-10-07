using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;

public class Dice
{
    #region Field
    private Random _randomizer = new Random();
    #endregion

    #region Properties
    public int Dots { get; set; }
    #endregion

    #region Constructors
    public Dice()
    {
        Dots = 6;
    }
    #endregion

    #region Methods
    public void Roll()
    {
        Dots = _randomizer.Next(1, 7);
    }
    #endregion
}