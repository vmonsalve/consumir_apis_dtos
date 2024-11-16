using System;
using CONSUMIR_API_DTOs.DTOs;

namespace CONSUMIR_API_DTOs.Service;

public interface IPostsService
{
    public Task<IEnumerable<PostDto>> Get();
}
