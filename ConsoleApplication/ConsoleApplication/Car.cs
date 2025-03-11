using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    /// <summary>
    /// Хранит информацию о машине.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Движок.
        /// </summary>
        private string _engine;

        /// <summary>
        /// Возвращает и задает данные для движка.
        /// </summary>
        private string Engine
        {
            get
            {
                return _engine;
            }
            set
            {
                _engine = value;
            }
        }

        /// <summary>
        /// Возвращает и задает данные для цены на машину.
        /// </summary>
        private string Cost {  get; set; }
    }
}
