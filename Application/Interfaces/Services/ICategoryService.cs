using Application.DTOs.Requests.CreateStoryRequestsDtos;
using Domain.Entities;

namespace Application.Interfaces.Services
{
    public interface ICategoryService
    {
        Task<Category> CreateCategoryAsync(CreateCategoryDto categoryDto);
    }
}
