using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenHouse.Core
{
    public class Table : IReadOnlyList<TableRow>
    {
        private TableRow[] _rows;

        internal Table(TableRow[] rows)
        {
            _rows = rows
                .OrderByDescending(r => r.Points)
                .ThenBy(r => r.GoalDifference)
                .ThenBy(r => r.GoalsScored)
                .ToArray();
        }

        public TableRow this[int index] => _rows[index];

        public int Count => _rows.Length;

        public IEnumerator<TableRow> GetEnumerator() => _rows.AsEnumerable().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _rows.GetEnumerator();
    }
}
