using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotLongPollingSample.DataBaseLogic.Tables
{
    internal class WordsTranslation
    {
        public int Id { get; set; }
        public string? Word { get; set; }
        public string? Translation { get; set; }
    }
}
