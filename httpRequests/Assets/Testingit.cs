using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Testingit : MonoBehaviour {

	void Start () {
		Dictionary<string,string> body = new Dictionary<string, string>();
		body.Add ("theVARIABLE","1000");
		body.Add ("myVARIABLE","5000");
		Postman.Instance.POST("http://requestb.in/1clj2u41","",body);
		/*Postman.Instance.GET("http://requestb.in/t9y5wqt9","");
		Postman.Instance.DELETE("http://requestb.in/t9y5wqt9","");
		Postman.Instance.PUT("http://requestb.in/t9y5wqt9","",
			new Dictionary<string, string>()
			{
			  { "myVariable", "1000000"}
			}
		);*/
	}
}
