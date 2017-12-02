$(document).ready(function() {
  $("#map").css({
		height: 500,
		width: 500
	});
	var myLatLng = new google.maps.LatLng(45.457293, 20.320561);//https://maps.google.com/?ll=45.32222,20.11322&spn=0.55907,1.352692&t=m&z=10
  MYMAP.init('#map', myLatLng, 11);
  
  $("#showmarkers").click(function(e){
		MYMAP.placeMarkers('markers.xml');
  });
});

var MYMAP = {
  map: null,
	bounds: null
}

MYMAP.init = function(selector, latLng, zoom) {
    var myOptions = {
        zoom: zoom,
        center: latLng,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    }
    this.map = new google.maps.Map($(selector)[0], myOptions);
    this.bounds = new google.maps.LatLngBounds();

    //var myLng=new google.maps.LatLng(45.247836, 19.848287);
    var markerposition = (45.247836, 19.848287);
    var marker = new google.maps.Marker({
        position: new google.maps.LatLng(45.507293, 20.320561),
        title: "Ekogradnja doo, Njegoseva bb, 23270 Melenci"
    });
    marker.setMap(this.map);

    var infoWindow = new google.maps.InfoWindow();
    var html = 'Ekogradnja doo, Njegoseva bb, 23270 Melenci';
    infoWindow.setContent('Ekogradnja doo, Njegoseva bb, 23270 Melenci');
    infoWindow.open(this.map, marker);

    var myLng = new google.maps.LatLng(45.393327, 20.363159);
    var markerposition = (45.380246, 20.396461);
    var marker = new google.maps.Marker({
        position: new google.maps.LatLng(45.393327, 20.363159),
        title: "Betonska baza"
    });
    marker.setMap(this.map);

    var infoWindow = new google.maps.InfoWindow();
    var html = 'Betonska baza, Industrijska zona Bagljas';
    infoWindow.setContent('Betonska baza, Industrijska zona Bagljas');
    infoWindow.open(this.map, marker);
    var center = new google.maps.LatLng(45.32222, 20.11322);

    var markerposition = (45.3956879, 20.2072527);
    var marker = new google.maps.Marker({
        position: new google.maps.LatLng(45.3956879, 20.2072527),
        title: "Sljunkara i separacija sljunka"
    });
    marker.setMap(this.map);

    var infoWindow = new google.maps.InfoWindow();
    var html = 'Sljunkara i separacija sljunka';
    infoWindow.setContent('Sljunkara i separacija Sljunka');
    infoWindow.open(this.map, marker);
    var center = new google.maps.LatLng(45.32222, 20.11322);
}

MYMAP.placeMarkers = function(filename) {
	$.get(filename, function(xml){
		$(xml).find("marker").each(function(){
			var name = $(this).find('name').text();
			var address = $(this).find('address').text();
			
			// create a new LatLng point for the marker
			var lat = $(this).find('lat').text();
			var lng = $(this).find('lng').text();
			var point = new google.maps.LatLng(parseFloat(lat),parseFloat(lng));
			
			// extend the bounds to include the new point
			MYMAP.bounds.extend(point);
			
			var marker = new google.maps.Marker({
				position: point,
				map: MYMAP.map
			});
			
			var infoWindow = new google.maps.InfoWindow();
			var html='<strong>'+name+'</strong.><br />'+address;
			google.maps.event.addListener(marker, 'click', function() {
				infoWindow.setContent(html);
				infoWindow.open(MYMAP.map, marker);
			});
			MYMAP.map.fitBounds(MYMAP.bounds);
		});
	});
}