using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GMapProyect
{
	public partial class GUI : Form
	{

		
		public GUI()
		{
			InitializeComponent();
		}

		private void gmap_Load(object sender, EventArgs e)
		{
			gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
			GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
			gmap.SetPositionByKeywords("New York, United States");

			gmap.ShowCenter = false;
			gmap.DragButton = MouseButtons.Left;
			gmap.CanDragMap = true;
			gmap.MapProvider = GMapProviders.GoogleMap;
			gmap.Position = new PointLatLng(40.652941, -75.436502);
			gmap.MinZoom = 0;
			gmap.MaxZoom = 20;
			gmap.Zoom = 9;
			gmap.AutoScroll = true;

			using (StreamReader reader = new StreamReader(".\\Data.csv"))
			{
				string line;

				while ((line = reader.ReadLine()) != null)
				{
					
					//Separating columns to array
					string[] X = line.Split(';');


					/* Do something with X */
				}
			}

		}

		public void readDocument() { 

		}

		public void Trys() {


			GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");

			GMapMarker markerCharlotte = new GMarkerGoogle(new PointLatLng(35.213889, -80.943056), GMarkerGoogleType.blue);
			markerCharlotte.Tag = "11057";
			markers.Markers.Add(markerCharlotte);
			GMapMarker markerFortLauderdale = new GMarkerGoogle(new PointLatLng(26.0725, -80.152778), GMarkerGoogleType.blue);
			markerFortLauderdale.Tag = "11697";
			markers.Markers.Add(markerFortLauderdale);
			GMapMarker markerFortMyers = new GMarkerGoogle(new PointLatLng(26.536111, -81.755278), GMarkerGoogleType.blue);
			markerFortMyers.Tag = "14635";
			markers.Markers.Add(markerFortMyers);
			GMapMarker markerPhoenix = new GMarkerGoogle(new PointLatLng(33.434167, -112.011667), GMarkerGoogleType.blue);
			markerPhoenix.Tag = "14107";
			markers.Markers.Add(markerPhoenix);
			GMapMarker markerAtlanta = new GMarkerGoogle(new PointLatLng(33.636667, -84.428056), GMarkerGoogleType.blue);
			markerAtlanta.Tag = "10397";
			markers.Markers.Add(markerAtlanta);
			GMapMarker markerDetroit = new GMarkerGoogle(new PointLatLng(42.2125, -83.353333), GMarkerGoogleType.blue);
			markerDetroit.Tag = "11433";
			markers.Markers.Add(markerDetroit);
			GMapMarker markerWestPalm = new GMarkerGoogle(new PointLatLng(26.6832, -80.0956), GMarkerGoogleType.blue);
			markerWestPalm.Tag = "14027";
			markers.Markers.Add(markerWestPalm);
			GMapMarker markerPittsburgh = new GMarkerGoogle(new PointLatLng(40.4882, -80.2263), GMarkerGoogleType.blue);
			markerPittsburgh.Tag = "14122";
			markers.Markers.Add(markerPittsburgh);
			GMapMarker markerPhiladelphia = new GMarkerGoogle(new PointLatLng(39.871944, -75.241111), GMarkerGoogleType.blue);
			markerPhiladelphia.Tag = "14100";
			markers.Markers.Add(markerPhiladelphia);

			gmap.Overlays.Add(markers);

			//Implementacion poligonos.
			/*GMapOverlay polyOverlay = new GMapOverlay("polygons");
			List<GMap.NET.PointLatLng> points = new List<GMap.NET.PointLatLng>();
			points.Add(new PointLatLng(40.652941, -75.436502));
			points.Add(new PointLatLng(40.002941, -75.006502));
			points.Add(new PointLatLng(40.300041, -75.300002));
			points.Add(new PointLatLng(40.652941, -75.436502));
			GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
			polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
			polygon.Stroke = new Pen(Color.Red, 1);
			polyOverlay.Polygons.Add(polygon);
			gmap.Overlays.Add(polyOverlay);*/
		}

	}
}
