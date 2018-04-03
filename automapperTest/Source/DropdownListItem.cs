using System;
namespace automapperTest.Source
{
    public class DropdownListItem<t> : IDropdownListItem
    {
        public string Text { get; set; }
        public t Value { get; set; }
    }
}
