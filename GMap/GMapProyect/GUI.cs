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
			gmap.MaxZoom = 24;
			gmap.Zoom = 9;
			gmap.AutoScroll = true;

			readInfo();
			for (int i=0; i<citys.Count(); i++) {
				if (/*La ciudad tiene delay*/true) {
					//Crear marcador color rojo
				}
				else {
					//Crear marcador color verde
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
				while ((count<100) && (line = reader.ReadLine()) != null) {
					String[] args = line.Split(',');

					String city = args[15].Replace("\"", "");
					String delay = args[32].Replace("\"", "");

					if (citysNames.Contains(city))						
					{
						if (Convert.ToDouble(delay) > 0)
						{
							//Asignar delay
						}
					}
					else {
						citysNames.Add(city);
						//Asignar delay 
					}
					count++;
				}

				reader.Close();
			}
		}

		public void trys() {
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
			GMapMarker marker6 = new GMarkerGoogle(new PointLatLng(42.2125, -83.353333), GMarkerGoogleType.blue);
			marker6.Tag = "DTW";
			GMapMarker marker7 = new GMarkerGoogle(new PointLatLng(26.6832, -80.0956), GMarkerGoogleType.blue);
			marker7.Tag = "PBI";
			GMapMarker marker8 = new GMarkerGoogle(new PointLatLng(40.4882, -80.2263), GMarkerGoogleType.blue);
			marker8.Tag = "PIT";
			GMapMarker marker9 = new GMarkerGoogle(new PointLatLng(39.871944, -75.241111), GMarkerGoogleType.blue);
			marker9.Tag = "PHL";
			GMapMarker marker10 = new GMarkerGoogle(new PointLatLng(27.975556, -82.533333), GMarkerGoogleType.blue);
			marker10.Tag = "TPA";
			GMapMarker marker11 = new GMarkerGoogle(new PointLatLng(25.793333, -80.290556), GMarkerGoogleType.blue);
			marker11.Tag = "MIA";
			GMapMarker marker12 = new GMarkerGoogle(new PointLatLng(33.9425, -118.408056), GMarkerGoogleType.blue);
			marker12.Tag = "LAX";
			GMapMarker marker13 = new GMarkerGoogle(new PointLatLng(32.847222, -96.851667), GMarkerGoogleType.blue);
			marker13.Tag = "DAL";
			GMapMarker marker14 = new GMarkerGoogle(new PointLatLng(39.499167, -119.768056), GMarkerGoogleType.blue);
			marker14.Tag = "RNO";
			GMapMarker marker15 = new GMarkerGoogle(new PointLatLng(36.08, -115.152222), GMarkerGoogleType.blue);
			marker15.Tag = "LAS";
			GMapMarker marker16 = new GMarkerGoogle(new PointLatLng(39.861667, -104.673056), GMarkerGoogleType.blue);
			marker16.Tag = "DEN";
			GMapMarker marker17 = new GMarkerGoogle(new PointLatLng(40.788333, -111.977778), GMarkerGoogleType.blue);
			marker17.Tag = "SLC";
			GMapMarker marker18 = new GMarkerGoogle(new PointLatLng(44.881944, -93.221667), GMarkerGoogleType.blue);
			marker18.Tag = "MSP";
			GMapMarker marker19 = new GMarkerGoogle(new PointLatLng(38.944444, -77.455833), GMarkerGoogleType.blue);
			marker19.Tag = "IAD";
			GMapMarker marker20 = new GMarkerGoogle(new PointLatLng(28.429444, -81.308889), GMarkerGoogleType.blue);
			marker20.Tag = "MCO";
			GMapMarker marker21 = new GMarkerGoogle(new PointLatLng(41.411667, -81.849722), GMarkerGoogleType.blue);
			marker21.Tag = "CLE";
			GMapMarker marker22 = new GMarkerGoogle(new PointLatLng(43.564444, -116.222778), GMarkerGoogleType.blue);
			marker22.Tag = "BOI";
			GMapMarker marker23 = new GMarkerGoogle(new PointLatLng(41.978611, -87.904724), GMarkerGoogleType.blue);
			marker23.Tag = "ORD";
			GMapMarker marker24 = new GMarkerGoogle(new PointLatLng(32.109666228, -110.937996248), GMarkerGoogleType.blue);
			marker24.Tag = "TUS";
			GMapMarker marker25 = new GMarkerGoogle(new PointLatLng(64.808996764, -147.853829918), GMarkerGoogleType.blue);
			marker25.Tag = "FAI";
			GMapMarker marker26 = new GMarkerGoogle(new PointLatLng(37.6432974268, -97.426498294), GMarkerGoogleType.blue);
			marker26.Tag = "ICT";
			GMapMarker marker27 = new GMarkerGoogle(new PointLatLng(35.436077, -82.541298), GMarkerGoogleType.blue);
			marker27.Tag = "AVL";
			GMapMarker marker28 = new GMarkerGoogle(new PointLatLng(39.053276, -84.663017), GMarkerGoogleType.blue);
			marker28.Tag = "CVG";
			GMapMarker marker29 = new GMarkerGoogle(new PointLatLng(55.35333192, -131.7083305), GMarkerGoogleType.blue);
			marker29.Tag = "KTN";
			GMapMarker marker30 = new GMarkerGoogle(new PointLatLng(42.7738469046, -84.5850476598), GMarkerGoogleType.blue);
			marker30.Tag = "LAN";
			GMapMarker marker31 = new GMarkerGoogle(new PointLatLng(35.040031, -89.981873), GMarkerGoogleType.blue);
			marker31.Tag = "MEM";
			GMapMarker marker32 = new GMarkerGoogle(new PointLatLng(33.656384, -101.821861), GMarkerGoogleType.blue);
			marker32.Tag = "LBB";
			GMapMarker marker33 = new GMarkerGoogle(new PointLatLng(40.50889, -122.29333), GMarkerGoogleType.blue);
			marker33.Tag = "RDD";
			GMapMarker marker34 = new GMarkerGoogle(new PointLatLng(43.128002, -77.665474), GMarkerGoogleType.blue);
			marker34.Tag = "ROC";
			GMapMarker marker35 = new GMarkerGoogle(new PointLatLng(57.0496, -135.361), GMarkerGoogleType.blue);
			marker35.Tag = "SIT";
			GMapMarker marker36 = new GMarkerGoogle(new PointLatLng(32.731770, -117.197624), GMarkerGoogleType.blue);
			marker36.Tag = "SAN";
			GMapMarker marker37 = new GMarkerGoogle(new PointLatLng(32.656582000000, -114.605972000000), GMarkerGoogleType.blue);
			marker37.Tag = "YUM";
			GMapMarker marker38 = new GMarkerGoogle(new PointLatLng(36.131687, -86.668823), GMarkerGoogleType.blue);
			marker38.Tag = "BNA";
			GMapMarker marker39 = new GMarkerGoogle(new PointLatLng(42.481806000000, -114.487750000000), GMarkerGoogleType.blue);
			marker39.Tag = "TWF";
			GMapMarker marker40 = new GMarkerGoogle(new PointLatLng(40.652941, -75.436502), GMarkerGoogleType.blue);
			marker40.Tag = "ABE";
			GMapMarker marker41 = new GMarkerGoogle(new PointLatLng(46.909829694, -114.087666316), GMarkerGoogleType.blue);
			marker41.Tag = "MSO";
			GMapMarker marker42 = new GMarkerGoogle(new PointLatLng(35.617500, -106.088333), GMarkerGoogleType.blue);
			marker42.Tag = "SAF";

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
