using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_interfejs.Interface
{
    interface IPersonRepository : IBookReposistory<Person, long>
    {
    }
}
