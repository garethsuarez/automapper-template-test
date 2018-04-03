using System;
using System.Collections.Generic;
using automapperTest.Source;

namespace automapperTest.Destination
{
    public class CreditApp
    {
        public string Name { get; set; }
        public string TemplateName { get; set; }
        public IList<IDropdownList> Lists { get; set; }

    }
}
