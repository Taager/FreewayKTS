using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class FreewayKanbanizeToScrumwise
{
	public void Main()
	{
        var kanbanizeApiKey = Login("", "");
		//
		// TODO: Add constructor logic here
		//
	}

    #region kanbanize
    static string Login(string username, string password)
    {
        RestClient client = new RestClient("https://freeway.kanbanize.com/index.php/api/kanbanize/login/");
        RestRequest request = new RestRequest(Method.POST);
        request.RequestFormat = DataFormat.Json;
        request.AddBody();
        request.AddParameter("email", "taager2201@gmail.com");
        request.AddParameter("pass", "9uYOY6SLe7gZHXlPBXxgVYr4ps0HyqgSP64JAOiR");

        var result = client.Execute<LoginResult>(request);
        //client.
        return result.Data.ApiKey;
    }
    
    #endregion
}
