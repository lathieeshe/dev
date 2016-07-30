using UnityEngine;
using System.Collections;
using System; //This allows the IComparable Interface

//This is the class you will be storing
//in the different collections. In order to use
//a collection's Sort() method, this class needs to
//implement the IComparable interface.
public class GameBoard : IComparable<GameBoard>
{
    public string maincategory;
    public int amount100;
    public string question100;
    public string answer100;

    public int amount200;
    public string question200;
    public string answer200;

    public int amount300;
    public string question300;
    public string answer300;

    public int amount400;
    public string question400;
    public string answer400;

    public int amount500;
    public string question500;
    public string answer500;

    public GameBoard(string MainCategory, int Amount100, string Questions100, string Answer100,
        int Amount200, string Questions200, string Answer200,
        int Amount300, string Questions300, string Answer300,
        int Amount400, string Questions400, string Answer400,
        int Amount500, string Questions500, string Answer500)
    {
        maincategory = MainCategory;
        amount100 = Amount100;
        question100 = Questions100;
        answer100 = Answer100;

        amount200 = Amount200;
        question200 = Questions200;
        answer200 = Answer200;

        amount300 = Amount300;
        question300 = Questions300;
        answer300 = Answer300;

        amount400 = Amount400;
        question400 = Questions400;
        answer400 = Answer400;

        amount500 = Amount400;
        question500 = Questions400;
        answer500 = Answer400;
           }

    //This method is required by the IComparable
    //interface. 
    public int CompareTo(GameBoard other)
    {
        if (other == null)
        {
            return 1;
        }

        //Return the difference in power.
        return amount100 - other.amount100;
    }
}