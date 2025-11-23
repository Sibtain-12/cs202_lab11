using System;
using System.Drawing;

namespace EventPlayground
{
    public class ColorEventArgs : EventArgs
    {
        public string ColorName { get; }
        public Color SelectedColor { get; }

        public ColorEventArgs(string colorName, Color selectedColor)
        {
            ColorName = colorName;
            SelectedColor = selectedColor;
        }
    }
}