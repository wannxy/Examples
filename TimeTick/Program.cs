using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TimeTick
{
    class Program
    {
        static void Main(string[] args)
        {
            Init();
            FileStream fs = new FileStream("C:\\Users\\F1\\Desktop\\words.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string longstr = sr.ReadToEnd();
            Console.WriteLine(longstr.Length);
            Regex regex = new Regex("[a-zA-Z]*");
            Match match = regex.Match(longstr);
            List<string> words = new List<string>(10000);
            while (match.Success)
            {
                if (words.Contains(match.Value))
                {
                    match = match.NextMatch();
                    continue;
                }
                if (match.Value.Length <= 1)
                {
                    match = match.NextMatch();
                    continue;
                }
                words.Add(match.Value);
                Add(match.Value);
            }

            Console.WriteLine(0);
        }

        private static HttpClient client;

        private static void Init()
        {
            HttpClientHandler handler = new HttpClientHandler
            {
                UseCookies = false// 这样自己设置的cookie才会生效
            };

            client = new HttpClient(handler);
            client.DefaultRequestHeaders.Host = "dict.youdao.com";
            client.DefaultRequestHeaders.Add("Cookie", "OUTFOX_SEARCH_USER_ID_NCOO=1970948155.9524207; OUTFOX_SEARCH_USER_ID=\" - 1192427089@10.169.0.84\"; _ntes_nnid=35a91a2a66f1f9840292574a72b571a9,1600589646049; JSESSIONID=abcdoV7j0N6y44YqkrXsx; webDict_HdAD=%7B%22req%22%3A%22http%3A//dict.youdao.com%22%2C%22width%22%3A960%2C%22height%22%3A240%2C%22showtime%22%3A5000%2C%22fadetime%22%3A500%2C%22notShowInterval%22%3A3%2C%22notShowInDays%22%3Afalse%2C%22lastShowDate%22%3A%22Mon%20Nov%2008%202010%22%7D; search-popup-show=-1; ACCSESSIONID=BB4144EE63AA8EDCBF83111AC7315827; DICT_SESS=v2|a5DMEcgEW0P40LzERMwZ0Yfh4lEP4Ym0OEnHOmhLzM0kWRMQBOMOGRPyRf6BOLYm06FO4lGkMeFRYM6Lwzh4gFROWkLQLk4qz0; DICT_PERS=v2|cqq||DICT||web||7776000000||1600702640758||123.55.157.241||qqD6C2D876494260CC2904C53E43A61382||TyhLq46MOM0QunMYEOLwF0OMnHOl6Mzf0wFOMUMnHqLRe4PMkGOMeyRTu0MJz0f6F0UE6M6ZhMp4RzG64PS6LJBR; DICT_LOGIN=3||1600702640762; DICT_UGC=7803f9151022a9dad72d22d1655cb86b|qqD6C2D876494260CC2904C53E43A61382; ___rl__test__cookies=1600702640377");
        }

        private static void Add(string word)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("http://dict.youdao.com/wordbook/ajax?action=addword&q={0}&date=Mon%20Sep%2021%202020%2023:37:47%20GMT+0800%20(%E4%B8%AD%E5%9B%BD%E6%A0%87%E5%87%86%E6%97%B6%E9%97%B4)&le=eng", word);
            Task<string> task = client.GetStringAsync(sb.ToString());
            task.Wait();
            string ret = task.Result;
            Console.WriteLine(string.Format("{0} -> {1}", word, ret));
        }
    }
}
