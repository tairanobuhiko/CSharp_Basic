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
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/1");

            // ② ステータスコードが成功かどうか確認
            response.EnsureSuccessStatusCode();

            // ③ レスポンスの本文（JSON）を取得
            string responseBody = await response.Content.ReadAsStringAsync();

            // ④ JSONをC#オブジェクトに変換
            Post post = JsonSerializer.Deserialize<Post>(responseBody);

            // ⑤ 結果を表示
            Console.WriteLine($"タイトル: {post.Title}");
            Console.WriteLine($"本文: {post.Body}");
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"エラー: {e.Message}");
        }
    }
}
