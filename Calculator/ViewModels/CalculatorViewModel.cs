using Reactive.Bindings;
using System.ComponentModel;
using System.Reactive.Linq;
using System;
using Prism.Mvvm;

namespace Calculator.ViewModels
{
    internal class CalculatorViewModel : BindableBase
    {
        public ReactiveProperty<string> InputNumber { get; private set; }
        public ReactiveProperty<string> InputSign { get; private set; }
        public ReactiveCommand NumberButton { get; private set; }
        public ReactiveCommand SignButton { get; } = new ReactiveCommand();
        public ReactiveCommand ClearButton { get; private set; }

        public CalculatorViewModel()
        {
            this.InputNumber = new ReactiveProperty<string>("0");
            this.InputSign = new ReactiveProperty<string>("");

            this.SignButton = new ReactiveCommand();
            this.SignButton.Subscribe(_ => InputSign.Value = "+");
        }
    }
}