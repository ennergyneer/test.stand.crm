using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Contact;

public class Contact : BaseEntity
{
    public DefaultContactType ContactType { get; set; }

    public AdditionalContactType? ContactTypeName { get; set; }

    public required string Value { get; set; }
}
