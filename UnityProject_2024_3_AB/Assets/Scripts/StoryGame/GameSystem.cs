using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Text;

namespace STORYGAME
{

#if UNITY_EDITOR                                
    [CustomEditor(typeof(GameSystem))]
    public class GameSysteEditor : Editor     
    {
        public override void OnInspectorGUI()        
        {
            base.OnInspectorGUI();                     

            GameSystem gameSystem = (GameSystem)target;

          
            if (GUILayout.Button("Reset Story Models"))
            {
                gameSystem.ResetStroyModles();
            }
        }
    }
#endif

    public class GameSystem : MonoBehaviour
    {
        public static GameSystem instance;           

        private void Awake()
        {
            instance = this;
        }

        public enum GAMESTATE
        {
            STORYSHOW,
            WAITSELECT,
            STORYEND,
            BATTLEMODE,
            BATTLEDONE,
            SHOPMODE,
            ENDMODE,
        }

        public GAMESTATE currentState;
        public StoryTableObject[] storyModels;
        public int currentStoryInex = 1;

#if UNITY_EDITOR
        [ContextMenu("Reset Story Models")]
        public void ResetStroyModles()
        {
            storyModels = Resources.LoadAll<StoryTableObject>(""); 
        }
#endif
    }
}