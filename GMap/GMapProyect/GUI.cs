using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using model;
using System.Drawing;

namespace GMapProyect
{
	public partial class GUI : Form
	{


		public GUI()
		{
			InitializeComponent();
		}

		private List<String> citysNames = new List<String>();
		private List<Citys> citys = new List<Citys>();

		public object GoogleMapProviders { get; private set; }

		private void gmap_Load(object sender, EventArgs e)
		{
			gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
			GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
			gmap.SetPositionByKeywords("New York, United States");

			gmap.ShowCenter = false;
			gmap.DragButton = MouseButtons.Left;
			gmap.CanDragMap = true;
			gmap.MapProvider = GoogleMapProvider.Instance;
			gmap.Position = new PointLatLng(40.652941, -75.436502);
			gmap.MinZoom = 0;
			gmap.MaxZoom = 24;
			gmap.Zoom = 9;
			gmap.AutoScroll = true;

			readInfo();

			GMapOverlay markers = new GMapOverlay("markers");

			for (int i=0; i<citys.Count(); i++) {
				if (citys.ElementAt(i).promDelays() > 1500) {
					
						GeoCoderStatusCode statusCode;
					PointLatLng? pointLatLng1 = OpenStreet4UMapProvider.Instance.GetPoint(citysNames.ElementAt(i), out statusCode);
					
					if (pointLatLng1 != null)
					{
						GMapMarker marker00 = new GMarkerGoogle(new PointLatLng(pointLatLng1.Value.Lat, pointLatLng1.Value.Lng), GMarkerGoogleType.red_dot); marker00.Tag = citysNames.ElementAt(i);
						marker00.ToolTipText = citysNames.ElementAt(i); marker00.ToolTip.Fill = Brushes.Black; marker00.ToolTip.Foreground = Brushes.White;
						marker00.ToolTip.Stroke = Pens.Black; marker00.ToolTip.TextPadding = new Size(10, 10); marker00.ToolTipMode = MarkerTooltipMode.OnMouseOver;
					markers.Markers.Add(marker00);
					gmap.Overlays.Add(markers);

					}
					
				}

					
				else {
					GeoCoderStatusCode statusCode;
					PointLatLng? pointLatLng1 = OpenStreet4UMapProvider.Instance.GetPoint(citysNames.ElementAt(i), out statusCode);
					if (pointLatLng1 != null)
					{
						GMapMarker marker00 = new GMarkerGoogle(new PointLatLng(pointLatLng1.Value.Lat, pointLatLng1.Value.Lng), GMarkerGoogleType.green_dot); marker00.Tag = citysNames.ElementAt(i);
						marker00.ToolTipText = citysNames.ElementAt(i); marker00.ToolTip.Fill = Brushes.Black; marker00.ToolTip.Foreground = Brushes.White;
						marker00.ToolTip.Stroke = Pens.Black; marker00.ToolTip.TextPadding = new Size(10, 10); marker00.ToolTipMode = MarkerTooltipMode.OnMouseOver;
						markers.Markers.Add(marker00);
						gmap.Overlays.Add(markers);

					}
				}
			}

		}

		public void readInfo() {
			var url = "https://query.data.world/s/6ankomqkxpsxwh4nnxjnw4ffvc7knf";
			var client = new WebClient();
			using (var stream = client.OpenRead(url))
			using (var reader = new StreamReader(stream)) {
				String line = reader.ReadLine();
				int count = 0;
				//Acomodar numero de entradas que lee (puse solo 100).
				while ((count<500) && (line = reader.ReadLine()) != null) {
					String[] args = line.Split(',');

					String city = args[15].Replace("\"", "");
					String delay = args[31].Replace("\"", "");

					if (citysNames.Contains(city))						
					{
						if (Convert.ToDouble(delay) > 0)
						{
							citys.ElementAt(citysNames.IndexOf(city)).addDelay(Convert.ToDouble(delay));
						}
					}
					else {
						citysNames.Add(city);
						Citys newCity = new Citys(city);
						citys.Add(newCity);
						citys.ElementAt(citysNames.IndexOf(city)).addDelay(Convert.ToDouble(delay));
					}
					count++;
				}

				reader.Close();
			}
		}

	}
}
