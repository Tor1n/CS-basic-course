using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    struct TempList
    {
        /// <summary>
        /// База данных сотрудников
        /// </summary>
        public Worker[] WorkersList;

        public TempList(params Worker[] Args)
        {
            WorkersList = Args;
        }

        public string this[int index]
        {
            get { return this.WorkersList[index].Print(); }
        }
    }
}
