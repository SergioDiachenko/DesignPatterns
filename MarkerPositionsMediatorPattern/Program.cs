using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkerPositionsMediatorPattern
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class MarkerMediator
    {
        private List<Marker> markers = new List<Marker>();

        public Marker CreateMarker()
        {
            var m = new Marker();
            m.SetMediator(this);
            this.markers.Add(m);
            return m;
        }

        public void Send(Point location, Marker marker)
        {
            this.markers.Where(_ => _ != marker).ToList().ForEach(_ => _.ReceiveLocation(location));
        }
    }

    public class Marker : Label
    {
        private MarkerMediator mediator;
        private Point mouseDownLocation;

        internal void SetMediator(MarkerMediator marker)
        {
            this.mediator = marker;
        }

        public Marker()
        {
            this.Text = "{Drag me}";
            this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MouseDown += OnMouseDown;
            this.MouseMove += OnMouseMove;
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.mouseDownLocation = e.Location;
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Text = this.Location.ToString();
                this.Left = e.X + this.Left - this.mouseDownLocation.X;
                this.Top = e.Y + this.Top - this.mouseDownLocation.Y;
                this.mediator.Send(this.Location, this);
            }
        }

        public void ReceiveLocation(Point location)
        {
            var distance = CalcDistance(location);

            if (distance < 100 && this.BackColor != Color.Red)
            {
                this.BackColor = Color.Red;
            }
            else if (distance >= 100 && this.BackColor != Color.Green)
            {
                this.BackColor = Color.Green;
            }

            double CalcDistance(Point point) =>
                Math.Sqrt(Math.Pow(point.X - this.Location.X, 2) +
                    Math.Pow(point.Y - this.Location.Y, 2));
        }
    }
}
