﻿using FeralExpressionsCore.Tests.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace FeralExpressionsCore.Tests.EF
{
    public class SubEntity : TestEntity, ISubEntity
    {
        public IList<ChildEntity> Children { get; set; }
        IEnumerable<IChildEntity> ISubEntity.Children => Children;
    }
}
