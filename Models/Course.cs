using System;
using Contentful.Core.Models;
using System.Collections.Generic;

namespace Mental_Health.Models
{
	public class Course
	{
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Asset> Images { get; set; }
        public string Description { get; set; }
        public SystemProperties Sys { get; set; }
        public Document Information { get; set; }
    }
}

