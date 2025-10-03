namespace Domain.ValueObjects
{
    public class Email
    {
        public string Value { get; }

        // TODO: Add validation logic
        public Email(string value)
        {
            Value = value;
        }
    }
}
