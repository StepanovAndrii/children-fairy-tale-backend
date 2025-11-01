using System.Collections.Immutable;

namespace Kazka.Application.Features.Book.Command.Add
{
    public partial record AddStoryCommand
    {
        public record ChapterRequest
            (
                ushort Order,
                string Title,
                string? AudioPath,
                ImmutableList<ParagraphRequest> Paragraphs
            )
        {
            public ChapterRequest
                (
                    ushort order,
                    string title,
                    string? audioPath,
                    IEnumerable<ParagraphRequest> paragraphs
                ) : this(order, title, audioPath, paragraphs.ToImmutableList())
            {
                
            }

            public virtual bool Equals(ChapterRequest? other)
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
                var hash = new HashCode();

                hash.Add(Order);
                hash.Add(Title);
                hash.Add(AudioPath);

                foreach (var paragraph in Paragraphs)
                {
                    hash.Add(paragraph);
                }

                return hash.ToHashCode();
            }
        }
    }
}
