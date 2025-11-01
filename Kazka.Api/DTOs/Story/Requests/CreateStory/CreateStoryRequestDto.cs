using System.Collections.Immutable;
using static Api.DTOs.Story.Requests.CreateStory.CreateStoryRequestDto;

namespace Api.DTOs.Story.Requests.CreateStory
{
    public partial record CreateStoryRequestDto
        (
            string Title,
            string? Description,
            uint CategoryId,
            string? CoverPath,
            uint LanguageId,
            ImmutableList<ChapterDto> Chapters
        )
    {
        public CreateStoryRequestDto
            (
                string title,
                string? description,
                uint categoryId,
                string coverPath,
                uint languageId,
                IEnumerable<ChapterDto> chapters
            ): this(title, description, categoryId, coverPath, languageId, chapters.ToImmutableList())
        {

        }

        public virtual bool Equals(CreateStoryRequestDto? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Title == other.Title
                && Description == other.Description
                && CoverPath == other.CoverPath
                && CategoryId == other.CategoryId
                && LanguageId == other.LanguageId
                && Chapters.SequenceEqual(other.Chapters);
        }

        public override int GetHashCode()
        {
            var hash = new HashCode();

            hash.Add(Title);
            hash.Add(Description);
            hash.Add(CoverPath);
            hash.Add(CategoryId);
            hash.Add(LanguageId);

            foreach (var chapter in Chapters)
            {
                hash.Add(chapter);
            }

            return hash.ToHashCode();
        }
    }
}
