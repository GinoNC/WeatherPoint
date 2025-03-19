using Newtonsoft.Json;
using CommonLibrary.Models;

namespace CommonLibrary
{
    public class Procedure
    {
        public async Task<List<DailyTemp>> GetTemp()
        {
            try
            {
                string url = "https://www.gcjelly.tokyo/weaapi/daily/N7Rd85DszH";
                List<DailyTemp> res = JsonConvert.DeserializeObject<List<DailyTemp>>(await JSONGet(url))!;

                return res;
            }
            catch
            {
                return [];
            }
        }
        
        private async Task<string> JSONGet(string _fullpath)
        {
            HttpResponseMessage res = await new HttpClient().GetAsync(_fullpath);
            res.EnsureSuccessStatusCode();
            return await res.Content.ReadAsStringAsync();
        }
    }
}