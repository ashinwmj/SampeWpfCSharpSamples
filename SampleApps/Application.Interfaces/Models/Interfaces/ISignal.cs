using System;

namespace Application.Interfaces.Models.Interfaces
{
    public interface ISignal
    {
         Guid Id { get; set; }
         string Name { get; set; }
         string Xml_data { get; set; }
    }
}
