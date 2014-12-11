using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Testingit : MonoBehaviour {

	void Start () {
		Dictionary<string,string> body = new Dictionary<string, string>();
		body.Add ("theVARIABLE","1000");
		body.Add ("myVARIABLE","5000");
		Postman.Instance.POST("http://requestb.in/nxt6x2nx","?e=1",body);
		Postman.Instance.GET("http://requestb.in/nxt6x2nx","");
		Postman.Instance.DELETE("http://requestb.in/nxt6x2nx","");
		Postman.Instance.PUT("http://requestb.in/nxt6x2nx","",
			new Dictionary<string, string>()
			{
			  { "myVariable", "1000000"}
			}
		);
	}
}
