using System.Collections.Immutable;

namespace Api.DTOs.Story.Requests.CreateStory
{
    public partial record CreateStoryRequestDto
    {
        public record ChapterDto
            (
                ushort Order,
                string Title,
                string? AudioPath,
                ImmutableList<ParagraphDto> Paragraphs
            )
        {
            public ChapterDto
                (
                    ushort order,
                    string title,
                    string? audioPath,
                    IEnumerable<ParagraphDto> paragraphs
                ) : this(order, title, audioPath, paragraphs.ToImmutableList())
            {

            }

            public virtual bool Equals(ChapterDto? other)
            {
                if (other is null) return false;
                if (ReferenceEquals(this, other)) return true;
                return Order == other.Order
                    && Title == other.Title
                    && AudioPath == other.AudioPath
                    && Paragraphs.SequenceEqual(other.Paragraphs);
            }

            public override int GetHashCode()
            {
                var hashCode = new HashCode();

                hashCode.Add(Order);
                hashCode.Add(Title);
                hashCode.Add(AudioPath);

                foreach (var paragraph in Paragraphs)
                {
                    hashCode.Add(paragraph);
                }

                return hashCode.ToHashCode();
            }
        }
    }
}
