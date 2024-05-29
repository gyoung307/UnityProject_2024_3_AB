using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Enums;

[CreateAssetMenu (fileName = "NewStory" , menuName = "ScriptableObjects/StoryModel")]
public class StoryModel : ScriptableObject
{


    public int storyNumber;
    public Texture2D mainImage;

    public enum STORYTYPE
    {
        MAIN,
        SUB,
        SERIAL
    }

    public STORYTYPE storyType;
    public bool storyDone;

    [TextArea(10, 10)]
    public string storyText;

    public GUILayoutOption[] option;

    public Option[] options;

    [System.Serializable]
    public class Option
    {
        public string optionText;
        public string buttonText;

        public EventCheck eventCheck;
    }

    [System.Serializable]
    public class EventCheck
    {
        public int checkvalue;

        public enum EventType : int
        {
            NONE,
            GoToBattle,
            CheckSTR,
            CheckDEX,
            CheckCON,
            CheckINT,
            CheckWIS,
            CheckCHA
        }

        public EventType eventType;

        public Result[] sucessResult;
        public Result[] failResult;
    }

    [System.Serializable]
    public class Result
    {

        public enum ResultType: int
        {
            ChangeHp,
            ChangeSp,
            AddExperience,
            GoToShop,
            GoToNextStory,
            GoToRandomStory
        }

        public ResultType resultType;
        public int value;
        public Stats stats;
    }
}