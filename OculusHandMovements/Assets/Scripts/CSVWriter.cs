using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CSVWriter : MonoBehaviour
{
    string filename = "";
    //public PrimaryButtonWatcher watcher;
    //public bool IsPressed = false;

    [System.Serializable]
    public class User
    {
        public string name; //Add to this list if we want to add more predetermined things
    }

    [System.Serializable]
    public class UserList
    {
        public User[] user;
    }

    public UserList myUserList = new UserList();
    void Start()
    {
        filename = Application.dataPath + "/test.csv";
        //watcher.primaryButtonPress.AddListener(onPrimaryButtonEvent);
    }
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Space))
        //    WriteCSV();
    }

    public void WriteCSV()
    {
        if(myUserList.user.Length > 0)
        {
            TextWriter tw = new StreamWriter(filename, false);
            tw.WriteLine("Name"); //Add to this list if we want to add more predetermined things
            tw.Close();

            tw = new StreamWriter(filename, true);

            for(int i = 0; i < myUserList.user.Length; i++)
            {
                tw.WriteLine(myUserList.user[i].name); //Add to this list if we want to add more predetermined things
            }
            tw.Close();
        }
    }
    /*public void onPrimaryButtonEvent(bool pressed)
    {
        IsPressed = pressed;
        if (pressed)
            WriteCSV();
    }*/
}
