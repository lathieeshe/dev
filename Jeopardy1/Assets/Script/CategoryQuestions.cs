using UnityEngine;
using System.Collections;
using LitJson;
using System.Collections.Generic;
using System.IO;
using System;

public class CategoryQuestions : MonoBehaviour
{
    private List<GameQuestions> database = new List<GameQuestions>();
    private JsonData QuestionData;

    void Start()
    {
        QuestionData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/StreamAssets/game1.json"));
        ConstructQuestionDatabase();
        Debug.Log(database[0].MainCategory);
    }
    /*
     *"id": 0,
     "MainCatergory": "What's My Name",
     "Amount100": 100,
     "Question100": "Name of my name",
     "Answer100": "Lathieeshe",
     */
    void ConstructQuestionDatabase()
    {
        for (int i = 0; i < QuestionData.Count; i++)
        {
            database.Add(new GameQuestions((int)QuestionData[i]["id"], QuestionData[i]["MainCatergory"].ToString(),
                (int)QuestionData[i]["Amount100"],QuestionData[i]["Question100"].ToString(),
                QuestionData[i]["Answer100"].ToString())
                );
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
