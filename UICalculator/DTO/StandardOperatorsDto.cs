namespace UICalculator.DTO
{
    public class StandardOperatorsDto
    {
        public enum EStandardOperators
        {
            DevideBy,
            MultiplyBy,
            Minus,
            Plus,
            Equals
        }

        protected EStandardOperators _eOperator;
        protected string _description;
        protected string _value;

        public EStandardOperators EOperator { get => _eOperator; private set => _eOperator = value; }
        public string Description { get => _description; private set => _description = value; }
        public string Value { get => _value; private set => this._value = value; }

        public StandardOperatorsDto(EStandardOperators eOperator, string description, string value)
        {
            EOperator = eOperator;
            Description = description;
            Value = value;
        }
    }
}
