using Newtonsoft.Json;
using System.Data;
namespace TopsApi.Business
{
    public class Serialize
    {
        public string ConvertToJson(DataTable dataTable)
        {
            return JsonConvert.SerializeObject(dataTable);
        }
    }
}