﻿using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces
{
    public interface IDocumentTypeRepository
    {
        List<DocumentTypeResponse> GetAll();

    }
}
