﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samba.Infrastructure.Data;

namespace Samba.Persistance.Data
{
    public static class SpecificationDaoExtentions
    {
        public static bool Exists<T>(this ISpecification<T> specification) where T : class,IValue
        {
            return Dao.Exists(specification.SatisfiedBy());
        }

        public static bool NotExists<T>(this ISpecification<T> specification) where T : class,IValue
        {
            return !Exists(specification);
        }

        public static string Validate<T>(this ISpecification<T> specification, string errorMessage) where T : class,IValue
        {
            return Exists(specification) ? errorMessage : "";
        }
    }
}
