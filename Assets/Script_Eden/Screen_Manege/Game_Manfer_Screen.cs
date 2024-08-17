using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manfer_Screen : MonoBehaviour
{
    // Start is called before the first frame update
    public static Action<Screen> Buttin_Screen_Press;
    [SerializeField] private Screen Current_Screen;
     private Dictionary<string, GameObject> Dictionary_MyScreen;
    public enum Screen
    {
        Main_Manu,
        Loading,
        Settings,
    };
    private void Change_Screen(Screen New_Screen)
    {
        Dictionary_MyScreen["Screen_"+ Current_Screen].SetActive(false);
        Current_Screen = New_Screen;
        Dictionary_MyScreen["Screen_" + Current_Screen].SetActive(true);
    }
    private void Awake()
    {
        Current_Screen = Screen.Main_Manu;
        GameObject[] Screen_Obj = GameObject.FindGameObjectsWithTag("Screens");
        if (Screen_Obj != null)
        {
            Dictionary_MyScreen = new Dictionary<string, GameObject>();
            foreach (GameObject obj in Screen_Obj)
            {
                Dictionary_MyScreen.Add(obj.name, obj);
                obj.SetActive(false);
                if (obj.name== "Screen_Main_Manu")
                {
                    obj.SetActive(true);
                }
            }
        }
      

    }
    private void OnEnable()
    {
        Buttin_Screen_Press += Change_Screen;
    }
    private void OnDisable()
    {
        Buttin_Screen_Press -= Change_Screen;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
