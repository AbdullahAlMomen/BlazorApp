using Microsoft.AspNetCore.Authentication.BearerToken;
using Microsoft.AspNetCore.SignalR.Protocol;
using System;

public class MessageState
{
	public string Message { get; set; }

	public void SetMessage(string message)
	{
		Message = message;
	}
	public void ClearMessage()
	{
		Message = "";
	}
}
