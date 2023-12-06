using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_interfejs.Interface
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
