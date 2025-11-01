using System.ComponentModel.DataAnnotations;

namespace Domain.ValueObjects
{
    public record Email
    {
        private static readonly EmailAddressAttribute _validator = new();
        public string Value { get; }
        public string Normalized => Value.ToLowerInvariant();
        public Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Email cannot be empty.", nameof(value));
            
            value = value.Trim();

            if (!_validator.IsValid(value))
                throw new ArgumentException("Invalid email format.", nameof(value));

            var parts = value.Split('@');

            if (parts.Length != 2)
                throw new ArgumentException("Email has to have one symbol '@", nameof(value));

            var local = parts[0];
            var domain = parts[1];

            if (local.StartsWith(".") || local.EndsWith(".") || local.Contains(".."))
                throw new ArgumentException("Local part has unsupported dots", nameof(value));

            if (!IsValidDomain(domain))
                throw new ArgumentException("Домен містить недопустимі символи.", nameof(value));

            Value = value;
        }
        private bool IsValidDomain(string domain)
        {
            if (string.IsNullOrWhiteSpace(domain))
                return false;

            foreach (var c in domain)
            {
                if (!(char.IsLetterOrDigit(c) || c == '-' || c == '.'))
                    return false;
            }

            if (!domain.Contains('.'))
                return false;

            return true;
        }

    }
}
