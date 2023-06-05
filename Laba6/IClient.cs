using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba6
{
    public interface IClient
    {
        string Name { get; set; }
        decimal GetPrice();
        string ToString();
    }
}