using Application.DTOs.Requests.CreateStoryRequestsDtos;
using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Endpoints
{
    public static class CategoryEndpoints
    {
        public static void MapAuthEndpoints(this RouteGroupBuilder group)
        {
            var storyGroup = group.MapGroup("/categories");

            storyGroup.MapPost("", CreateCategory);
        }

        public static async Task<IResult> CreateCategory
            (
                CreateCategoryDto categoryDto,
                [FromServices] ICategoryService categoryService
            )
        {
            return Results.Ok(await categoryService.CreateCategoryAsync(categoryDto));
        }
    }
}
