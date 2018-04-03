using System.Collections.Generic;

namespace automapperTest.Source
{
    public abstract class DropdownList : IDropdownList
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class DropdownList<T> : DropdownList
    {
        public IList<DropdownListItem<T>> Items { get; set; }
    }
}
