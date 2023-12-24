using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Request;

public class Board : BaseEntity
{
    public required string Name { get; set; }
}
