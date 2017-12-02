//$(document).ready(function(){
var mapCanvas = document.getElementById('map');
if (mapCanvas != null) {
    var mapOptions = {
        center: new google.maps.LatLng(45.458, 20.347),
        zoom: 11,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    }

    var map = new google.maps.Map(mapCanvas, mapOptions)

    var place = new google.maps.Marker({
        position: new google.maps.LatLng(45.50724, 20.31887),
        map: map
    });
    var place1 = new google.maps.Marker({
        position: new google.maps.LatLng(45.3937959, 20.3631698),
        map: map
    })
    var place2 = new google.maps.Marker({
        position: new google.maps.LatLng(45.3938716, 20.209278),
        map: map
    })

    var infoWindow = new google.maps.InfoWindow();

    //google.maps.event.addListener(place, 'click', function () {
    infoWindow.setContent("Ekogradnja doo, Njegoševa bb, 23270 Melenci");
    infoWindow.open(map, place);
    //});

    var infoWindow1 = new google.maps.InfoWindow();
    //google.maps.event.addListener(place1, 'click', function () {
    infoWindow1.setContent("Betonska baza, industrijska zona Bagljaš, Zrenjanin");
    infoWindow1.open(map, place1);

    infoWindow2 = new google.maps.InfoWindow();
    infoWindow2.setContent("Šljunkara i separacija šljunka");
    infoWindow2.open(map, place2);
    //})


    //google.maps.event.addDomListener(window, 'load', initialize);
}
//})