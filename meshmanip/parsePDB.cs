using UnityEngine;
using System.Collections;

public class parsePDB : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string text = System.IO.File.ReadAllText(@"g:\Hua\toto.txt");
        System.Console.WriteLine("Contents of toto.txt = {0}", text);
        //Debug.Log("Contents of toto.txt = {0}");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
