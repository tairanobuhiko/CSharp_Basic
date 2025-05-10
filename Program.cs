using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

// 投稿データのモデル（JSONと対応）
public class Post
{
    [JsonPropertyName("userId")]
    public int UserId { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("body")]
    public string Body { get; set; }
}

class Program
{
    static async Task Main(string[] args)
    {
        // HttpClientのインスタンスを作成
        using HttpClient client = new HttpClient();

        try
        {
            // ① APIにGETリクエストを送信
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/");

            // ② ステータスコードが成功かどうか確認
            response.EnsureSuccessStatusCode();

            // ③ レスポンスの本文（JSON）を取得
            string responseBody = await response.Content.ReadAsStringAsync();

            // ④ JSONをC#オブジェクトに変換してリストで受け取る
            List<Post>? posts = JsonSerializer.Deserialize<List<Post>>(responseBody);

            // ⑤ 特定のユーザーIDのみ抽出（Linq）
            List<Post>? filterPosts = posts
                .Where(p => p.UserId == 5)
                .ToList();

            // ⑥ 結果を表示(5件だけ)
            if (filterPosts != null)
            {
                foreach (Post post in filterPosts)
                {
                    Console.WriteLine($"ユーザーID: {post.UserId}");
                    Console.WriteLine($"投稿ID: {post.Id}");
                    Console.WriteLine($"タイトル: {post.Title}");
                    Console.WriteLine($"本文: {post.Body}");
                }
            }
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"エラー: {e.Message}");
        }
    }
}
