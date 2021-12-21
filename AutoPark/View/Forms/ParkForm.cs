using AutoPark.Presenters;
using AutoPark.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AutoPark
{
    public partial class ParkForm : Form, IParkView
    {
        public IParkPresenter Presenter { get; set; }
        public ParkForm()
        {
            InitializeComponent();
        }

        public void CloseForm()
        {
            throw new NotImplementedException();
        }

        public void showListView(object sender, EventArgs e) {
            UpdateListViewCars(Presenter.GetCars());
        }

        public void UpdateParkView()
        {
            string number = textBox1.Text.Trim();
            List<string[]> cars = number != "" ? Presenter.GetCarsByPartNumber(number) : Presenter.GetCars();
            UpdateListViewCars(cars);
        }

        public void ShowForm()
        {
            Application.Run(this);
        }

        public void ShowMessage(string message)
        {
            throw new NotImplementedException();
        }

        private void ParkForm_Load_1(object sender, EventArgs e)
        {
            UpdateParkView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Presenter.ShowCarView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string number = listView1.SelectedItems[0].Name;
            Presenter.ShowCarView(number);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string number = listView1.SelectedItems[0].Name;
            Presenter.DeleteCar(number);
        }

        private void UpdateListViewCars(List<string[]> cars) {
            listView1.Items.Clear();
            listView1.SmallImageList = new ImageList();
            listView1.SmallImageList.ImageSize = new Size(40, 40);

            for (int i = 0; i < cars.Count; i++) {
                Bitmap bitmap = GetBitmap(Presenter.FindPictureByNumber(cars[i][1]));
                listView1.SmallImageList.Images.Add(bitmap);
                ListViewItem item = new ListViewItem(cars[i]);
                item.Name = cars[i][1];
                item.ImageIndex = i;
                listView1.Items.Add(item);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateParkView();
        }

        private Bitmap GetBitmap(Image img) {
            if (img != null) {
                return new Bitmap(img);
            }
            Bitmap emptyImage = new Bitmap(40, 40);
            using (Graphics gr = Graphics.FromImage(emptyImage))
            {
                gr.Clear(Color.White);
            }
            return emptyImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Presenter.ShowCategoriesView();
        }
    }
}
