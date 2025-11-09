namespace Kazka.Application.Results
{
    public enum SuccessType
    {
        Ok = 200,
        NoContent = 204
    }
    public class Success<T>
    {
        public T? Value { get; init; }
        public SuccessType Type { get; init; }

        private Success(T? value, SuccessType type)
        {
            Value = value;
            Type = type;
        }
        public static Success<T> Create(T? value, SuccessType type)
            => new Success<T>(value, type);
    }
}
