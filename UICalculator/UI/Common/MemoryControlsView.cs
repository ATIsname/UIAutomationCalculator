using System.Windows.Automation;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestTools.UIItems;
using TestTools.Utils;
using UICalculator.DTO;
using static UICalculator.DTO.MemoryControlsDto;

namespace UICalculator.UI.Common
{
    public class MemoryControlsView : BaseChildView
    {
        private static List<MemoryControlsDto> MemoryControlsList = new List<MemoryControlsDto>()
        {
            new MemoryControlsDto(EMemoryControls.ClearAllMemory, "Clear all memory", "MC"),
            new MemoryControlsDto(EMemoryControls.MemoryRecall, "Memory recall", "MR"),
            new MemoryControlsDto(EMemoryControls.MemoryAdd, "Memory add", "M+"),
            new MemoryControlsDto(EMemoryControls.MemorySubtract, "Memory subtract", "M-"),
            new MemoryControlsDto(EMemoryControls.MemoryStore, "Memory store", "MS"),
            new MemoryControlsDto(EMemoryControls.OpenMemoryFlyout, "Open memory flyout", "M>")
        };

        public MemoryControlsView(UIItem parent) : base(parent)
        {
        }

        public TTGroupBox MemoryControlsGroup => TTGroupBox.Get(SearchCriteria.ByAutomationId("StandardOperators"),
            "Standard Operators", _parent, Timeouts.Small);

        public TTButton GetOperator(EMemoryControls eMemoryControl)
        {
            return TTButton.Get(SearchCriteria.ByNativeProperty(AutomationElement.NameProperty, eMemoryControl),
                MemoryControlsGroup.UIItem, Timeouts.Small);
        }

        public void Click(EMemoryControls eMemoryControl)
        {
            GetOperator(eMemoryControl).Click();
        }
    }
}
