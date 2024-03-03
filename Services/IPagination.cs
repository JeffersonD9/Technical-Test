using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technical_Test.Services
{
    public interface IPagination
    {
        public void ShowOrder(DataGridView dataGrid, TextBox text);
        public void Next(DataGridView grid);
        public void Previous(DataGridView grid);

    }
}
