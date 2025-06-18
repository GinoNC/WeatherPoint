using Newtonsoft.Json;
using CommonLibrary.Models;

namespace CommonLibrary
{
    public class Procedure
    {
        private static async Task<string> JSONGet(string _fullpath)
        {
            HttpResponseMessage res = await new HttpClient().GetAsync(_fullpath);
            res.EnsureSuccessStatusCode();
            return await res.Content.ReadAsStringAsync();
        }

        public static async Task<List<DailyTemp>> GetListDailyTemp(string _region, int _year)
        {
            try
            {
                if (_region == "") throw new Exception();
                
                string url = "https://www.gcjelly.tokyo/weaapi/daily/N7Rd85DszH/" + _region;
                if (_year > 0) url += "/" + _year.ToString();

                List<DailyTemp> res = JsonConvert.DeserializeObject<List<DailyTemp>>(await JSONGet(url))!;

                return res;
            }
            catch
            {
                return [];
            }
        }
    }
}