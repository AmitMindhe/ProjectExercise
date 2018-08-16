using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExercise.Core
{
    public class PaginationList<TModel> : PaginationModel
    {
        public List<TModel> Items { get; set; }
        public int TotalItemCount { get; set; }
    }

    public class PaginationModel
    {
        private int _PageSize = 10;
        private int _PageNumber = 1;
        private string _SearchText = "";

        public int PageSize
        {
            get
            {
                return _PageSize;
            }
            set
            {
                if (value == 0)
                    _PageSize = 10;
                else
                    _PageSize = value;
            }
        }

        public int PageNumber
        {
            get
            {
                return _PageNumber;
            }
            set
            {
                if (value == 0)
                    _PageNumber = 1;
                else
                    _PageNumber = value;
            }
        }

        public string SearchText
        {
            get
            {
                return _SearchText;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    _SearchText = "";
                else
                    _SearchText = value;
            }
        }
    }
}
