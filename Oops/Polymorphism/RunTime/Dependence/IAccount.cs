using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependence
{
    public interface IAccount
    {
        int AccountNumber{get;set;}
        string Name{get;set;}

        double Balance{get;set;}
    }
}