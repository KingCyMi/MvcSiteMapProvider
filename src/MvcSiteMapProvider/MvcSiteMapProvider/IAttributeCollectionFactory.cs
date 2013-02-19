﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvcSiteMapProvider.Globalization;

namespace MvcSiteMapProvider
{
    /// <summary>
    /// Contract for the abstract factory that creates new instances of <see cref="T:MvcSiteMapProvider.IAttributeCollection"/> at runtime.
    /// </summary>
    public interface IAttributeCollectionFactory
    {
        IAttributeCollection Create(ISiteMap siteMap, ILocalizationService localizationService);
    }
}
