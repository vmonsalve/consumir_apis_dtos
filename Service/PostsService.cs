using System;
using System.Text.Json;
using CONSUMIR_API_DTOs.DTOs;

namespace CONSUMIR_API_DTOs.Service;

public class PostsService : IPostsService
{
    private HttpClient _httpClient;

    public PostsService()
    {
        _httpClient = new HttpClient();

    }

    public async Task<IEnumerable<PostDto>> Get()
    {
        var url = "https://jsonplaceholder.typicode.com/posts";
        var response = await _httpClient.GetAsync(url);
        var body = await response.Content.ReadAsByteArrayAsync();

        var options = new JsonSerializerOptions{
            PropertyNameCaseInsensitive = true,
        };

        var posts = JsonSerializer.Deserialize<IEnumerable<PostDto>>(body, options);

        return posts;
    }

}
