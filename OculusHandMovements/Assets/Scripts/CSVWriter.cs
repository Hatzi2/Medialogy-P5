using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Inputs;
using UnityEngine.XR;
using System.Linq;
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
        public float position;
        public float runTime;
        public float guardianTime;
    }

    [System.Serializable]
    public class UserList
    {
        public User[] user;
    }

    public UserList myUserList = new UserList();
    //public string filePath = Application.dataPath + "/test2.csv";

    void Start()
    {


        filename = Application.dataPath + "/test2.csv";

        //WriteCSV();
        //watcher.primaryButtonPress.AddListener(onPrimaryButtonEvent);
    }
    void Update()
    {

        WriteCSV();


    }

    bool headerLine = true;
    float timeNow = 0.0f;
    float timeReset = 0.0f;
    private Vector3 headPosition;
    private List<XRNodeState> nodeStates = new List<XRNodeState>();

    public void WriteCSV()
    {
        timeNow += Time.deltaTime;
        timeReset += Time.deltaTime;
        InputTracking.GetNodeStates(nodeStates);
        var headState = nodeStates.FirstOrDefault(node => node.nodeType == XRNode.Head);
    
        headState.TryGetPosition(out headPosition);

        
        TextWriter tw = new StreamWriter(filename, true);
        if(myUserList.user.Length > 0)
        {
            if (headerLine == true)
            {
                tw.WriteLine("Name, PositionX, PositionY, RunTime, GuardianTime"); //Add to this list if we want to add more predetermined things
                tw.Close();
                tw = new StreamWriter(filename, true);
                headerLine = false;
            }
            

            
        if (timeReset > 2.0f)
        {
            for(int i = 0; i < myUserList.user.Length; i++)
            {
                
                tw.WriteLine(myUserList.user[i].name + "," + headPosition[0] + "," + headPosition[2] + "," + timeNow + "," + myUserList.user[i].guardianTime); //Add to this list if we want to add more predetermined things
            }
            
            timeReset = 0;
        }
        tw.Close();
        Debug.Log(timeNow);
        

            
            
            //File.AppendAllText(Application.dataPath + "/test2.csv", "hej, ");
            //tw.Close();
        }
    }
    /*public void onPrimaryButtonEvent(bool pressed)
    {
        IsPressed = pressed;
        if (pressed)
            WriteCSV();
    }*/
}
