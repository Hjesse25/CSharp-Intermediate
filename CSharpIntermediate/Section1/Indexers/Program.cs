using Indexers;

var cookie = new HttpCookie();
cookie["name"] = "Jesse";
Console.WriteLine(cookie["name"]);