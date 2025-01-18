using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Interfaces;
using Exiled.API.Features;
using System.ComponentModel;


namespace Broadcasts
{
    public class Config : IConfig
    {
        [Description("Включен ли плагин")]
        public bool IsEnabled { get; set; } = true;

        [Description("Включен ли дебагмод")]
        public bool Debug { get; set; } = false;

        [Description("время бродкаста")]
        public ushort Duration { get; set; } = 1;

        [Description("текст бродкаста при прыжке")]
        public string Textjump { get; set; } = "<color=green>ты прыгнул</color>";
    }
}