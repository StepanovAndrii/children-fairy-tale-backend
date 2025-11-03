using Kazka.Application.Features.Stories.Responses.Add;
using MediatR;
using System.Collections.Immutable;
using static Kazka.Application.Features.Book.Command.Add.AddStoryCommand;

namespace Kazka.Application.Features.Book.Command.Add
{
    public partial record AddStoryCommand
        (
            string Title,
            string? Description,
            uint CategoryId,
            string? CoverPath,
            uint LanguageId,
            ImmutableList<ChapterRequest> Chapters
        ): IRequest<AddStoryResponse>
    {
        public AddStoryCommand
            (
                string title,
                string? description,
                uint categoryId,
                string? coverPath,
                uint languageId,
                IEnumerable<ChapterRequest> chapters
            ): this(title, description, categoryId, coverPath, languageId, chapters.ToImmutableList())
        {

        }

        public virtual bool Equals(AddStoryCommand? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Title == other.Title
                && Description == other.Description
                && CategoryId == other.CategoryId
                && CoverPath == other.CoverPath
                && LanguageId == other.LanguageId
                && Chapters.SequenceEqual(other.Chapters);
        }

        public override int GetHashCode()
        {
            var hash = new HashCode();

            hash.Add(Title);
            hash.Add(Description);
            hash.Add(CategoryId);
            hash.Add(CoverPath);
            hash.Add(LanguageId);

            foreach (var chapter in Chapters)
            {
                hash.Add(chapter);
            }

            return hash.ToHashCode();
        }
    }
}
