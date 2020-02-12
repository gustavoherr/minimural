using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace MiniMural.Controls
{
    public sealed partial class StickyNoteControl : UserControl, IWidget, INotifyPropertyChanged
    {
        public StickyNoteControl()
        {
            this.InitializeComponent();
            ManipulationMode = ManipulationModes.All;
            Tapped += StickyNoteControl_Tapped;
        }

        private void StickyNoteControl_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // TODO: add or remove from parent canvas selected widgets collection
        }

        public WidgetTypeEnum WidgetType => WidgetTypeEnum.StickyNote;

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (object.Equals(storage, value)) return false;
            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        public StickyNote StickyNoteObject
        {
            get { return (StickyNote)GetValue(StickyNoteObjectProperty); }
            set { SetValue(StickyNoteObjectProperty, value); }
        }

        public static readonly DependencyProperty StickyNoteObjectProperty = DependencyProperty.Register("StickyNoteObject", typeof(StickyNote), typeof(StickyNoteControl), new PropertyMetadata(false, StickyNoteObjectPropertyChanged));

        private static void StickyNoteObjectPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs ea)
        {
            StickyNoteControl instance = dependencyObject as StickyNoteControl;
            StickyNote note = ea.NewValue as StickyNote;
            instance.DisplayText = note.Text;
            instance.DisplayColor = Windows.UI.ColorHelper.FromArgb(note.Color.A, note.Color.R, note.Color.G, note.Color.B);
        }

        private string mDisplayName;
        public string DisplayText
        {
            get { return mDisplayName; }

            private set
            {
                SetProperty(ref mDisplayName, value);
            }
        }

        private Windows.UI.Color mDisplayColor;
        public Windows.UI.Color DisplayColor
        {
            get { return mDisplayColor; }
            private set
            {
                SetProperty(ref mDisplayColor, value);
            }
        }
    }
}
