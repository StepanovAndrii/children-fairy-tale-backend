using Application.DTOs.Requests.CreateStoryRequestsDtos;
using Application.Interfaces.Services;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IStoryRepository _storyRepository;
        public CategoryService(IStoryRepository storyRepository)
        {
            _storyRepository = storyRepository;
        }
        public async Task<Category> CreateCategoryAsync(CreateCategoryDto categoryDto)
        {
            return await _storyRepository.CreateCategoryAsync(new Category
            {
                Name = categoryDto.CategoryName
            });
        }
    }
}
