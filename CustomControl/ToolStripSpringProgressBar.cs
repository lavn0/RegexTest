using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControl
{
    /// <summary>
    /// Spring属性を拡張したTooStrip用ProgressBar
    /// </summary>
    public class ToolStripSpringProgressBar : ToolStripProgressBar
    {
        [Browsable(true)]
        [DefaultValue(false)]
        public bool Spring
        {
            get;
            set;
        }

        public override Size GetPreferredSize(Size constrainingSize)
        {
            if (Spring)
            {
                // Use the default size if the text box is on the overflow menu
                // or is on a vertical ToolStrip.
                if (IsOnOverflow || Owner.Orientation == Orientation.Vertical)
                {
                    return DefaultSize;
                }

                // Declare a variable to store the total available width as 
                // it is calculated, starting with the display width of the 
                // owning ToolStrip.
                Int32 width = Owner.DisplayRectangle.Width;

                // Subtract the width of the overflow button if it is displayed. 
                if (Owner.OverflowButton.Visible)
                {
                    width = width - Owner.OverflowButton.Width -
                        Owner.OverflowButton.Margin.Horizontal;
                }

                // Declare a variable to maintain a count of ToolStripSpringProgressBar 
                // items currently displayed in the owning ToolStrip. 
                Int32 springBoxCount = 0;

                foreach (ToolStripItem item in Owner.Items)
                {
                    // Ignore items on the overflow menu.
                    if (item.IsOnOverflow) continue;

                    if (item is ToolStripSpringProgressBar)
                    {
                        // For ToolStripSpringProgressBar items, increment the count and 
                        // subtract the margin width from the total available width.
                        springBoxCount++;
                        width -= item.Margin.Horizontal;
                    }
                    else
                    {
                        // For all other items, subtract the full width from the total
                        // available width.
                        width = width - item.Width - item.Margin.Horizontal;
                    }
                }

                // If there are multiple ToolStripSpringProgressBar items in the owning
                // ToolStrip, divide the total available width between them. 
                if (springBoxCount > 1) width /= springBoxCount;

                // If the available width is less than the default width, use the
                // default width, forcing one or more items onto the overflow menu.
                if (width < DefaultSize.Width) width = DefaultSize.Width;

                // Retrieve the preferred size from the base class, but change the
                // width to the calculated width. 
                Size size = base.GetPreferredSize(constrainingSize);
                size.Width = width;
                return size;
            }
            else
            {
                return this.Size;
            }
        }
    }
}