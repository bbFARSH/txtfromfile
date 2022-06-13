using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AutoAdapter2k
{
    class GridArray
    {
        MyArray _myArray;
        DataGridView _dataGridView;
        public GridArray(DataGridView dataGridView,MyArray myArray)
        {
            _myArray = myArray;
            _dataGridView = dataGridView;
            dataGridView.ColumnCount = myArray.N;
            dataGridView.RowCount = myArray.N;
        }
        public void ShowInfo()
        {
            for (int i = 0; i < _myArray.N; i++)
                for (int j = 0; j < _myArray.N; j++)
                {
                    _dataGridView.Rows[i].Height = 30;
                    _dataGridView.Columns[i].Width = 30;
                    _dataGridView[i, j].Value = _myArray.Arr[j, i].ToString();
                    if (_myArray.Arr[j, i] == 0)
                        _dataGridView[i, j].Style.BackColor = Color.Yellow;
                    else
                        _dataGridView[i, j].Style.BackColor = Color.White;
                }
        }
    }
}
