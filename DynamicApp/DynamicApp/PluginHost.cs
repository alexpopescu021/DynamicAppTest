using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Text;

namespace DynamicApp
{
    class PluginHost
    {
        [ImportMany]
        public IEnumerable<Func<string>> GetNames { get; set; }
    }
}
