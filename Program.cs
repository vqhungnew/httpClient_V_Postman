var client = new HttpClient();
var request = new HttpRequestMessage(HttpMethod.Get, "https://ipinfo.io/115.73.211.45/geo");
var response = await client.SendAsync(request);
response.EnsureSuccessStatusCode();
Console.WriteLine(await response.Content.ReadAsStringAsync());