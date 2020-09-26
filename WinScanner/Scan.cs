using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WinScanner
{
    abstract class Scan
    {

        public Scan(TabControl tabView, String title, String description, Image imageResource)
        {
            TabPage newPage = new TabPage(title);
            tabView.TabPages.Add(newPage);

            Label descriptionText = new Label();
            descriptionText.Text = description;
            descriptionText.Left = 3;
            descriptionText.Top = 3;
            descriptionText.AutoSize = true;
            newPage.Controls.Add(descriptionText);

            PictureBox image = new PictureBox();
            image.Image = imageResource;
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            image.Size = new Size(431, 281);
            image.Left = 6;
            image.Top = 49;
            newPage.Controls.Add(image);

            Button button = new Button();
            button.Text = "Run scan";
            button.Size = new Size(201, 58);
            button.Left = 5;
            button.Top = 336;
            button.Click += new EventHandler(OnScan);
            newPage.Controls.Add(button);
        }

        public abstract void OnScan(object sender, EventArgs e);
    }
}
