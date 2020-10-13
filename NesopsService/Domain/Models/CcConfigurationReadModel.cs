using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcConfigurationReadModel
    {
        #region Generated Properties
        public int ConfigurationId { get; set; }

        public string ConfigurationTitle { get; set; }

        public string ConfigurationKey { get; set; }

        public string ConfigurationValue { get; set; }

        public string ConfigurationDescription { get; set; }

        public int ConfigurationType { get; set; }

        public string UseFunction { get; set; }

        public string SetFunction { get; set; }

        #endregion

    }
}
