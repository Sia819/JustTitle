using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WindowTitleControl
{
    public class CustomTitleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string info)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));

        private int _TitleButton_Height;
        public int MaximizeButton_Height
        {   get => _TitleButton_Height;   
            set { _TitleButton_Height = value; OnPropertyChanged(nameof(MaximizeButton_Height)); } 
        }

        private int _titleButton_Width;
        public int MaximizeButton_Width
        {
            get => _titleButton_Width;
            set { _titleButton_Width = value; OnPropertyChanged(nameof(MaximizeButton_Width)); }
        }

        private int _titleButton_Margin;
        public int TitleButton_Width
        {
            get => _titleButton_Width;
            set { _titleButton_Width = value; OnPropertyChanged(nameof(MaximizeButton_Width)); }
        }
        // TODO : Close Button Margin


        public CustomTitleViewModel()
        {
            MaximizeButton_Height = 29;
            MaximizeButton_Width = 45;
        }

        
    }
}
