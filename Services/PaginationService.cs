using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Technical_Test.Services
{
    public class PaginationService : IPagination
    {
        public void Next(DataGridView grid)
        {
            int currentRowIndex = grid.CurrentCell.RowIndex;

        
            if (currentRowIndex < grid.Rows.Count - 1)
            {
               
                grid.CurrentCell = grid[grid.CurrentCell.ColumnIndex, currentRowIndex + 1];
            }
        }

        public void Previous(DataGridView grid)
        {
            int currentRowIndex = grid.CurrentCell.RowIndex;

            
            if (currentRowIndex > 0)
            {
                
                grid.CurrentCell = grid[grid.CurrentCell.ColumnIndex, currentRowIndex - 1];
            }
        }

        public void ShowOrder(DataGridView dataGrid, TextBox text)
        {

            string texBox = text.Text.ToLower();
            bool validate = false;

            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                string result = (row.Cells[0].Value ?? "").ToString().ToLower();

                if (result == texBox)
                {
                    dataGrid.ClearSelection();
                    row.Selected = true;

                    validate = true;

                    break;
                }
            }

            if (!validate)
            {
                MessageBox.Show("Not Found");
            }
        }
    }
}
