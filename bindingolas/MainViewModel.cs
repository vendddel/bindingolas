using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bindingolas
{
    internal class MainViewModel : ViewModelBase
    {
        private string _text = "";
        public string Text { get { return _text; } set { _text = value; OnPropertyChanged(nameof(Text)); OnPropertyChanged(nameof(TextLength)); } }


        private string _selectedColor = "Blue";
        public string SelectedColor { get { return _selectedColor; } set { _selectedColor = value; OnPropertyChanged(nameof(SelectedColor)); } }


        public int TextLength { get { return _text.Length; } }

        private bool _isBold = false;
        public bool IsBold
        {
            get { return _isBold; }
            set { _isBold = value; OnPropertyChanged(nameof(IsBold)); }
        }
    }
}
