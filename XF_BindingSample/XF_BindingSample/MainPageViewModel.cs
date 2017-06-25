using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XF_BindingSample
{
    public class MainPageViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        int count = 0;
        public MainPageViewModel()
        {
            this.LblCount = count.ToString();

            this.CountUpCommand = new Command(() => CountUp());
        }

        public ICommand CountUpCommand { get; }
        private void CountUp()
        {
            count++;

            this.LblCount = count.ToString();
        }

        private string lblCount;
        public string LblCount
        {
            set
            {
                if (lblCount != value)
                {
                    lblCount = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("LblCount"));
                    }
                }
            }
            get
            {
                return lblCount;
            }
        }
    }
}
