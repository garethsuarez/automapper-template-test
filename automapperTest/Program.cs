using System;
using System.Collections.Generic;
using AutoMapper;
using automapperTest.Destination;
using automapperTest.Source;

namespace automapperTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Template, CreditApp>();
            });

            var iMapper = config.CreateMapper();
 
            var creditApp = iMapper.Map<Template, CreditApp>(GetTemplate());

 


        }

        static private Template GetTemplate()
        {
            var template = new Template
            {
                TemplateName = "test template",
                Lists = new List<IDropdownList>{
                    new DropdownList<string>{ 
                        Name = "test", 
                        Items = new List<DropdownListItem<string>>
                        {
                            new DropdownListItem<string> { Text="test 1", Value="test 1"},
                            new DropdownListItem<string> { Text="test 2", Value="test 2"}

                        }
                    },
                    new DropdownList<int>{
                        Name = "test 2",
                        Items = new List<DropdownListItem<int>>
                        {
                            new DropdownListItem<int> { Text="test 1", Value=1},
                            new DropdownListItem<int> { Text="test 2", Value=2}
                        }
                    }
                }
            };
            return template;
        }
    }
}
