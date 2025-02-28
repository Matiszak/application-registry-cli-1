﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApplicationRegistry.Collector.Model
{
    public class ApplicationInfo
    {
        [Required]
        public string ApplicationCode { get; set; }

        [Required]
        public string IdEnvironment { get; set; }

        [Required]
        public string Version { get; set; }

        public string IdCommit { get; set; }

        public string Framework { get; set; } = ".NET";


        public string ToolsVersion { get; set; }

        public string RepositoryUrl { get; set; }

        public bool ExecutionSucceeded { get; set; } = true;

        public long ExecutionDuration { get; set; }

        // Navigation properties
        public List<ApplicationVersionSpecification> Specifications { get; } = new List<ApplicationVersionSpecification>();

        public List<ApplicationVersionDependency> Dependencies { get; } = new List<ApplicationVersionDependency>();

        public Dictionary<string, bool> BatchStatuses { get; } = new Dictionary<string, bool>();

    }

}
