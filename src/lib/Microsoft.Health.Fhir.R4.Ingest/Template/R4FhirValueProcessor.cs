﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Hl7.Fhir.Model;

namespace Microsoft.Health.Fhir.Ingest.Template
{
    public class R4FhirValueProcessor : CollectionFhirValueProcessor<(DateTime start, DateTime end, IEnumerable<(DateTime, string)> values), Element>
    {
        public R4FhirValueProcessor()
            : base(
                new SampledDataFhirValueProcessor(),
                new CodeableConceptFhirValueProcessor(),
                new QuantityFhirValueProcessor())
        {
        }
    }
}