using UnityEngine;
using System.Collections;
using LitJson;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine.UI;

public class CategoryQuestions : MonoBehaviour
{
    private List<GameQuestions> database = new List<GameQuestions>();
    private JsonData QuestionData;
  //  public Text Jeo;
   public Button[,] board = new Button[5,6];
   List<GameBoard> gameboard = new List<GameBoard>();

    void Start()
    {

           
        QuestionData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/StreamAssets/game1.json"));
        ConstructQuestionDatabase();
        // Debug.Log(database[0].MainCategory);
        foreach (var data in gameboard)
        {
         //   Debug.Log("Main Category: " + data.maincategory);
           // Debug.Log("Amount 100: " + data.amount200);
          //  Debug.Log("Question 100: " + data.question200);
           // Debug.Log("Answer 100: " + data.answer200);
        }
       var objects = GameObject.FindGameObjectsWithTag("Player");
        var objectCount = objects.Length;
        for (var j = 0; j < objects.Length; j++)
        {
          //  Debug.Log(objects[j].GetComponent<Text>().text);

            objects[j].GetComponent<Text>().text = database[j].Answer;
        }
        
       

    }
   
    void ConstructQuestionDatabase()
    {
        for (int i = 0; i < QuestionData.Count; i++)
        {
            /* database.Add(new GameQuestions((int)QuestionData[i]["id"], QuestionData[i]["MainCatergory"].ToString(),
                 (int)QuestionData[i]["Amount100"], QuestionData[i]["Question100"].ToString(), QuestionData[i]["Answer100"].ToString(),
                 (int)QuestionData[i]["Amount200"], QuestionData[i]["Question200"].ToString(), QuestionData[i]["Answer200"].ToString(),
                 (int)QuestionData[i]["Amount300"], QuestionData[i]["Question300"].ToString(), QuestionData[i]["Answer300"].ToString(),
                 (int)QuestionData[i]["Amount400"], QuestionData[i]["Question400"].ToString(), QuestionData[i]["Answer400"].ToString(),
                 (int)QuestionData[i]["Amount500"], QuestionData[i]["Question500"].ToString(), QuestionData[i]["Answer500"].ToString())
                 );*/
            Debug.Log(QuestionData.Count);
           Debug.Log((int)QuestionData[i]["Amount100"]);
            //gameboard(QuestionData[i]["MainCatergory"].ToString(), (int)QuestionData[i]["Amount100"], QuestionData[i]["Question100"].ToString(),QuestionData[i]["Answer100"].ToString());
            gameboard.Add(new GameBoard(QuestionData[i]["MainCatergory"].ToString(), 
                (int)QuestionData[i]["Amount100"], QuestionData[i]["Question100"].ToString(), QuestionData[i]["Answer100"].ToString(),
                (int)QuestionData[i]["Amount200"], QuestionData[i]["Question200"].ToString(), QuestionData[i]["Answer200"].ToString(),
                (int)QuestionData[i]["Amount300"], QuestionData[i]["Question300"].ToString(), QuestionData[i]["Answer300"].ToString(),
                (int)QuestionData[i]["Amount400"], QuestionData[i]["Question400"].ToString(), QuestionData[i]["Answer400"].ToString(),
                (int)QuestionData[i]["Amount500"], QuestionData[i]["Question500"].ToString(), QuestionData[i]["Answer500"].ToString()
                ));
        }
    }
}
public class GameQuestions
{
    public int ID { get; set; }
    public string MainCategory { get; set; }
    public int Amount { get; set; }
    public string Question { get; set; }
    public string Answer { get; set; }

    public GameQuestions(int id, string maincategory, int amount, string question, string answer)
    {
        this.ID = id;
        this.MainCategory = maincategory;
        this.Amount = amount;
        this.Question = question;
        this.Answer = answer;
    }
}
