namespace UICalculator.DTO
{
    public class MemoryControlsDto
    {
        public enum EMemoryControls
        {
            ClearAllMemory,
            MemoryRecall,
            MemoryAdd,
            MemorySubtract,
            MemoryStore,
            OpenMemoryFlyout
        }

        protected EMemoryControls _eMemoryControls;
        protected string _description;
        protected string _value;

        public EMemoryControls MemoryControls { get => _eMemoryControls; private set => _eMemoryControls = value; }
        public string Description { get => _description; private set => _description = value; }
        public string Value { get => _value; private set => _value = value; }

        public MemoryControlsDto(EMemoryControls eMemoryControls, string description, string value)
        {
            MemoryControls = eMemoryControls;
            Description = description;
            Value = value;
        }
    }
}
