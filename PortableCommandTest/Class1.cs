using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;

namespace PortableCommandTest
{
    public class Class1
    {

        public ICommand Command { get; set; }

        public Class1()
        {

            Command = new MvxCommand(Execute, CanExecute);
        }

        private bool CanExecute()
        {
            return true;
        }

        private void Execute()
        {
        }
    }
}
