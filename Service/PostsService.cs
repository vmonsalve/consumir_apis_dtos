using System;
using System.Text.Json;
using CONSUMIR_API_DTOs.DTOs;

namespace CONSUMIR_API_DTOs.Service;

public class PostsService : IPostsService
{
    private HttpClient _httpClient;

    public PostsService(HttpClient httpClient)
    {
        _httpClient = httpClient;

    }

    public async Task<IEnumerable<PostDto>> Get()
    {
        var response = await _httpClient.GetAsync(_httpClient.BaseAddress);
        var body = await response.Content.ReadAsByteArrayAsync();

        var options = new JsonSerializerOptions{
            PropertyNameCaseInsensitive = true,
        };

        var posts = JsonSerializer.Deserialize<IEnumerable<PostDto>>(body, options);

        return posts ?? Enumerable.Empty<PostDto>();
;
    }

}
