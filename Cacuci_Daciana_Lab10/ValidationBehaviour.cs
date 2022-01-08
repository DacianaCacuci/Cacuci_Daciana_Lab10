using System;
using System.Collections.Generic;
using System.Text;
using Cacuci_Daciana_Lab10.Data;
using Cacuci_Daciana_Lab10.Models;
using Xamarin.Forms;

namespace Cacuci_Daciana_Lab10
{
    class ValidationBehaviour : Behavior<Editor>
    {
        protected override void OnAttachedTo(Editor entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }
        protected override void OnDetachingFrom(Editor entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }
        void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            ((Editor)sender).BackgroundColor =
            string.IsNullOrEmpty(args.NewTextValue) ? Color.Red : Color.Default;
        }
    }
}
