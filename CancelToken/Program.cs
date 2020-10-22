using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Threading;
using System.Threading.Tasks;

public struct Rectangle
{
    public int columns;
    public int rows;
}

class CancelByPolling
{
    static void Main()
    {
        Test();
    }

    public static void Test()
    {
        Random rand = new Random();
        CancellationTokenSource cts = new CancellationTokenSource();
        List<Task<Article>> tasks = new List<Task<Article>>();
        TaskFactory factory = new TaskFactory(cts.Token);
        
        
        foreach (var t in new string[] { "Article", "Post", "Love" })
        {
            Console.WriteLine("开始请求");
            tasks.Add(factory.StartNew(() =>
            {
                var article = new Article { Type = t };
                if (t == "Article")
                {
                    article.Data.Add("文章已加载");
                }
                else
                {
                    for (int i = 1; i < 5; i++)
                    {
                        Thread.Sleep(rand.Next(1000, 2000));
                        Console.WriteLine("load:{0}", t);
                        article.Data.Add($"{t}_{i}");
                    }
                }
                return article;
            }, cts.Token));
        }

        Console.WriteLine("开始合并结果");
        foreach (var task in tasks)
        {
            Console.WriteLine();
            var result = task.Result;
            foreach (var d in result.Data)
            {
                Console.WriteLine("合并中...{0}:{1}", result.Type, d);
            }
            task.Dispose();
        }

        cts.Cancel();
        cts.Dispose();

        Console.WriteLine("\nIsCancellationRequested:{0}", cts.IsCancellationRequested);
    }

    private class Article
    {
        public List<string> Data = new List<string>(1);

        public string Type { set; get; } = "";
    }
}