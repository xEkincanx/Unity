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
	
	
	public void POST(string url ,string urlParams,Dictionary<string,string> body){
		url = url + urlParams;
		HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
		request.Credentials = CredentialCache.DefaultCredentials;
		request.Method = "POST";
		request.ContentType = "application/x-www-form-urlencoded";
		
		//Creating & Adding Body:
		string theBody = "";
		foreach(KeyValuePair<string,string> bodyPart in body){
			theBody = theBody + bodyPart.Key + "=" + bodyPart.Value + "&";
		}
		byte[] byteArray = Encoding.UTF8.GetBytes(theBody);
		request.ContentLength = byteArray.Length;
		Stream dataStream = request.GetRequestStream();
		dataStream.Write(byteArray, 0,byteArray.Length);
		dataStream.Close ();
		
		//Getting the Response
		WebResponse response = request.GetResponse();
		dataStream = response.GetResponseStream();
		StreamReader reader = new StreamReader(dataStream);
		string message = reader.ReadToEnd();
		
		reader.Close(); response.Close(); dataStream.Close(); //CLEANING MEMORY
		Debug.Log("Response: "+message); //CONSOLE MESSAGE !
	}
	
	public void POST(string url ,Dictionary<string,string> urlParams,Dictionary<string,string> body){
		url = url + "?";
		foreach(KeyValuePair<string,string> urlP in urlParams){
			url = url + "&" + urlP.Key + "=" + urlP.Value;
		}
		HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
		request.Credentials = CredentialCache.DefaultCredentials;
		request.Method = "POST";
		request.ContentType = "application/x-www-form-urlencoded";
		
		//Creating & Adding Body:
		string theBody = "";
		foreach(KeyValuePair<string,string> bodyPart in body){
			theBody = theBody + bodyPart.Key + "=" + bodyPart.Value + "&";
		}
		byte[] byteArray = Encoding.UTF8.GetBytes(theBody);
		request.ContentLength = byteArray.Length;
		Stream dataStream = request.GetRequestStream();
		dataStream.Write(byteArray, 0,byteArray.Length);
		dataStream.Close ();
		
		//Getting the Response
		WebResponse response = request.GetResponse();
		dataStream = response.GetResponseStream();
		StreamReader reader = new StreamReader(dataStream);
		string message = reader.ReadToEnd();
		
		reader.Close(); response.Close(); dataStream.Close(); //CLEANING MEMORY
		Debug.Log("Response: "+message); //CONSOLE MESSAGE !
	}
	
	
	public void GET(string url,Dictionary<string,string> urlParams){
		url = url + "?";
		foreach(KeyValuePair<string,string> urlP in urlParams){
			url = url + "&" + urlP.Key + "=" + urlP.Value;
		}
		
		HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
		request.Credentials = CredentialCache.DefaultCredentials;
		request.Method = "GET";
		
		//Getting the Response
		WebResponse response = request.GetResponse ();
		Stream dataStream = response.GetResponseStream ();
		StreamReader reader = new StreamReader (dataStream);
		string message = reader.ReadToEnd ();
		
		reader.Close(); response.Close(); dataStream.Close(); //CLEANING MEMORY
		Debug.Log ("Response: "+message); //CONSOLE MESSAGE !
	}
	
	public void GET(string url,string urlParams){
		url = url + urlParams;
		HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
		request.Credentials = CredentialCache.DefaultCredentials;
		request.Method = "GET";
		
		//Getting the Response
		WebResponse response = request.GetResponse ();
		Stream dataStream = response.GetResponseStream ();
		StreamReader reader = new StreamReader (dataStream);
		string message = reader.ReadToEnd ();
		
		reader.Close(); response.Close(); dataStream.Close(); //CLEANING MEMORY
		Debug.Log ("Response: "+message); //CONSOLE MESSAGE !
	}
	
	
	public void DELETE(string url,Dictionary<string,string> urlParams){
		url = url + "?";
		foreach(KeyValuePair<string,string> urlP in urlParams){
			url = url + "&" + urlP.Key + "=" + urlP.Value;
		}
		
		HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
		request.Credentials = CredentialCache.DefaultCredentials;
		request.Method = "DELETE";
		
		//Getting the Response
		WebResponse response = request.GetResponse ();
		Stream dataStream = response.GetResponseStream ();
		StreamReader reader = new StreamReader (dataStream);
		string message = reader.ReadToEnd ();
		
		reader.Close(); response.Close(); dataStream.Close(); //CLEANING MEMORY
		Debug.Log ("Response: "+message); //CONSOLE MESSAGE !
	}
	
	public void DELETE(string url,string urlParams){
		url = url + urlParams;
		HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
		request.Credentials = CredentialCache.DefaultCredentials;
		request.Method = "DELETE";
		
		//Getting the Response
		WebResponse response = request.GetResponse ();
		Stream dataStream = response.GetResponseStream ();
		StreamReader reader = new StreamReader (dataStream);
		string message = reader.ReadToEnd ();
		
		reader.Close(); response.Close(); dataStream.Close(); //CLEANING MEMORY
		Debug.Log ("Response: "+message); //CONSOLE MESSAGE !
	}
	
	
	public void PUT(string url ,string urlParams,Dictionary<string,string> body){
		url = url + urlParams;
		
		HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
		request.Credentials = CredentialCache.DefaultCredentials;
		request.Method = "PUT";
		request.ContentType = "application/x-www-form-urlencoded";
		
		//Creating & Adding Body:
		string theBody = "";
		foreach(KeyValuePair<string,string> bodyPart in body){
			theBody = theBody + bodyPart.Key + "=" + bodyPart.Value + "&";
		}
		byte[] byteArray = Encoding.UTF8.GetBytes(theBody);
		request.ContentLength = byteArray.Length;
		Stream dataStream = request.GetRequestStream();
		dataStream.Write(byteArray, 0,byteArray.Length);
		dataStream.Close ();
		
		//Getting the Response
		WebResponse response = request.GetResponse();
		dataStream = response.GetResponseStream();
		StreamReader reader = new StreamReader(dataStream);
		string message = reader.ReadToEnd();
		
		reader.Close(); response.Close(); dataStream.Close(); //CLEANING MEMORY
		Debug.Log("Response: "+message); //CONSOLE MESSAGE !
	}
	
	public void PUT(string url ,Dictionary<string,string> urlParams,Dictionary<string,string> body){
		url = url + "?";
		foreach(KeyValuePair<string,string> urlP in urlParams){
			url = url + "&" + urlP.Key + "=" + urlP.Value;
		}
		
		HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
		request.Credentials = CredentialCache.DefaultCredentials;
		request.Method = "PUT";
		request.ContentType = "application/x-www-form-urlencoded";
		
		//Creating & Adding Body:
		string theBody = "";
		foreach(KeyValuePair<string,string> bodyPart in body){
			theBody = theBody + bodyPart.Key + "=" + bodyPart.Value + "&";
		}
		byte[] byteArray = Encoding.UTF8.GetBytes(theBody);
		request.ContentLength = byteArray.Length;
		Stream dataStream = request.GetRequestStream();
		dataStream.Write(byteArray, 0,byteArray.Length);
		dataStream.Close ();
		
		//Getting the Response
		WebResponse response = request.GetResponse();
		dataStream = response.GetResponseStream();
		StreamReader reader = new StreamReader(dataStream);
		string message = reader.ReadToEnd();
		
		reader.Close(); response.Close(); dataStream.Close(); //CLEANING MEMORY
		Debug.Log("Response: "+message); //CONSOLE MESSAGE !
	}
}
