using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Text;

public class Postman{
	
	private Postman(){} //Private Constructor
	
	private static Postman myInstance;
	
	public static Postman Instance{
		get{
			if(myInstance==null){
				myInstance = new Postman();
			}
			return myInstance;
		}
	}
	
	public HttpWebRequest createWebRequest(string url ,string method){
		HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
		request.Credentials = CredentialCache.DefaultCredentials;
		request.Method = method;
		request.ContentType = "application/x-www-form-urlencoded";
		return request;
	}
	
	public Stream createDataStream(Dictionary<string,string> body ,HttpWebRequest request){
		string theBody = "";
		foreach(KeyValuePair<string,string> bodyPart in body){
			theBody = theBody + bodyPart.Key + "=" + bodyPart.Value + "&";
		}
		byte[] byteArray = Encoding.UTF8.GetBytes(theBody);
		request.ContentLength = byteArray.Length;
		Stream dataStream = request.GetRequestStream();
		dataStream.Write(byteArray, 0,byteArray.Length);
		dataStream.Close ();
		return dataStream;
	}
	
	public string getResponse(HttpWebRequest request){
		WebResponse response = request.GetResponse();
		Stream backStream = response.GetResponseStream();
		StreamReader reader = new StreamReader(backStream);
		string message = reader.ReadToEnd();
		reader.Close(); response.Close(); backStream.Close();
		return message;
	}
	
	public string addURLParams(string url,Dictionary<string,string> urlParams){
		url = url + "?";
		foreach(KeyValuePair<string,string> urlP in urlParams){
			url = url + "&" + urlP.Key + "=" + urlP.Value;
		}
		return url;
	}
	
	public void POST(string url ,string urlParams,Dictionary<string,string> body){
		HttpWebRequest request = createWebRequest(url+urlParams,"POST"); //Creating Request !
		createDataStream(body,request); //Creating DataStream
		Debug.Log("Response: "+getResponse(request)); //CONSOLE MESSAGE !
	}
	
	public void POST(string url ,Dictionary<string,string> urlParams,Dictionary<string,string> body){
		HttpWebRequest request = createWebRequest(addURLParams(url,urlParams),"POST"); //Creating Request !
		createDataStream(body,request); //Creating DataStream
		Debug.Log("Response: "+getResponse(request)); //CONSOLE MESSAGE !
	}
	
	
	public void GET(string url,Dictionary<string,string> urlParams){
		HttpWebRequest request = createWebRequest(addURLParams(url,urlParams),"GET");
		Debug.Log("Response: "+getResponse(request)); //CONSOLE MESSAGE !
	}
	
	public void GET(string url,string urlParams){
		HttpWebRequest request = createWebRequest(url+urlParams,"GET");
		Debug.Log("Response: "+getResponse(request)); //CONSOLE MESSAGE !
	}
	
	
	public void DELETE(string url,Dictionary<string,string> urlParams){
		HttpWebRequest request = createWebRequest(addURLParams(url,urlParams),"DELETE");
		Debug.Log("Response: "+getResponse(request)); //CONSOLE MESSAGE !
	}
	
	public void DELETE(string url,string urlParams){
		HttpWebRequest request = createWebRequest(url+urlParams,"DELETE");
		Debug.Log("Response: "+getResponse(request)); //CONSOLE MESSAGE !
	}
	
	
	public void PUT(string url ,string urlParams,Dictionary<string,string> body){
		HttpWebRequest request = createWebRequest(url+urlParams,"PUT"); //Creating Request !
		createDataStream(body,request); //Creating DataStream
		Debug.Log("Response: "+getResponse(request)); //CONSOLE MESSAGE !
	}
	
	public void PUT(string url ,Dictionary<string,string> urlParams,Dictionary<string,string> body){
		HttpWebRequest request = createWebRequest(addURLParams(url,urlParams),"PUT"); //Creating Request !
		createDataStream(body,request); //Creating DataStream
		Debug.Log("Response: "+getResponse(request)); //CONSOLE MESSAGE !
	}
}
