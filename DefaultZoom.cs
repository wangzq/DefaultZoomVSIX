using System;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace DefaultZoomVSIX
{
    [Export(typeof(IWpfTextViewCreationListener))]
    [ContentType("any")]
    internal class DefaultZoom : IWpfTextViewCreationListener
    {
        public void TextViewCreated(IWpfTextView textView)
        {
            textView.GotAggregateFocus += TextView_GotAggregateFocus;
        }

        private void TextView_GotAggregateFocus(object sender, EventArgs e)
        {
            var textView = (IWpfTextView)sender;
            textView.ZoomLevel = 99.0;
        }
    }
}
