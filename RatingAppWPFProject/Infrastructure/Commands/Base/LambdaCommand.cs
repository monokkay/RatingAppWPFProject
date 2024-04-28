using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RatingAppWPFProject.Infrastructure.Commands.Base
{
    internal class LambdaCommand : CommandBase
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        public LambdaCommand(Action<object> execute, Func<object, bool> canExecute = null!)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public override bool CanExecute(object? parameter) => true;

        public override void Execute(object? parameter)
        {
            try
            {
                _execute(parameter!);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
