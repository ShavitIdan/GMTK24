using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Screen : MonoBehaviour
{
    // Start is called before the first frame update
    public void ButtonEvent_Screen(string Screen_Name)
    {
        Game_Manfer_Screen.Screen new_Screen;
        bool Success = Enum.TryParse<Game_Manfer_Screen.Screen>(Screen_Name, out new_Screen);
        if (Success)
            Game_Manfer_Screen.Buttin_Screen_Press?.Invoke(new_Screen);
        else
            Debug.Log("Name_Error");
    }
    public void Exit_Game()
    {
        Application.Quit();
    }
    public void play_Button()
    {
        SceneManager.LoadScene("Game_Sense");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
