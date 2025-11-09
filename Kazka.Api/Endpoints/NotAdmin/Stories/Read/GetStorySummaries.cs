using Application.Interfaces.Services;
using Kazka.Api.Attributes;
using Kazka.Api.Dtos.Responces;
using Kazka.Api.Extensions;
using Kazka.Application.Requests.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Kazka.Api.Endpoints.NotAdmin.Stories.Read
{
    //[EndpointVersion(1)]
    //public class GetStorySummaries : IEndpoint
    //{
    //    public void Map(IEndpointRouteBuilder app)
    //    {
    //        app.MapGet("/stories", async
    //            (
    //                [FromServices] IStoryBusinessLogic storyBusinessLogic,
    //                int? categoryId,
    //                int? limit,
    //                int? offset
    //            ) =>
    //        {
    //            var query = new GetStorySummaryQuery
    //            {
    //                CategorId = categoryId,
    //                Limit = limit,
    //                Offset = offset
    //            };

    //            var result = await storyBusinessLogic.GetAllStorySummariesAsync(query);

    //            return result.ToActionResult(stories => 
    //                stories
    //                    .Select(story => new StoryResponce
    //                    {
    //                        Id = story.Id,
    //                        Title = story.Title,
    //                        CoverUrl = story.CoverUrl
    //                    })
    //            );
    //        });
    //    }
    //}
}
