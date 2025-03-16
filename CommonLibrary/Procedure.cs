namespace CommonLibrary
{
    public class Procedure
    {
        public static async Task<string> JSONGet(string _fullpath)
        {
            HttpResponseMessage res = await new HttpClient().GetAsync(_fullpath);
            res.EnsureSuccessStatusCode();
            return await res.Content.ReadAsStringAsync();
        }
    }
}