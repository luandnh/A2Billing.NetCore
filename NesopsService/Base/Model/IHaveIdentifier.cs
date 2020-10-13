using System;
using System.Collections.Generic;
using System.Text;

namespace NesopsService.Base.Model
{
    public interface IHaveIdentifier
    {
        long Id { get; set; }
    }
}
