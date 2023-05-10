using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
using static System.Net.WebRequestMethods;
using System.Text.RegularExpressions;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace CuaHangTraSua.GUI
{
    public partial class ThongTinCuaHang : Form
    {
        public ThongTinCuaHang()
        {
            InitializeComponent();

        }


    

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e)
        {

            GMapOverlay overlay = new GMapOverlay("overlay");

            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(21.046474670275785, 105.78488569054694), GMarkerGoogleType.red_dot);
            overlay.Markers.Add(marker);

            // Thiết lập nhà cung cấp bản đồ
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            // Thiết lập chế độ xem bản đồ
           
                gMapControl1.Overlays.Add(overlay);
            // Thiết lập vị trí ban đầu
            gMapControl1.Position = new PointLatLng(21.08777075272765, 105.74021336970732); // Vị trí Hồ Chí Minh
                                                                            // Thiết lập mức zoom ban đầu
            gMapControl1.Zoom = 15;
            // Cho phép điều khiển bằng chuột
            gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.DragButton = MouseButtons.Right;
            gMapControl1.CanDragMap = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }
    }


}
