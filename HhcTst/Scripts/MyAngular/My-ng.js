
var app = angular.module('MyApp',[]); // extending from previously created angularJS  module in the First part
app.controller('MyController', function ($scope,LocationService) {
    // expained about controller in Part2 // Here LocationService (Service) Injected
    $scope.ZoneID = null;
    $scope.StateID = null;
    $scope.ZonesList = null;
    $scope.StatesList = null;

    $scope.StateTextToShow = "Select State";
    $scope.Result = "";

    // Populate Country
    LocationService.GetZones().then(function (d) {
        
        $scope.ZonesList = d.data;
    }, function (error) {
        alert('Error! hereeeeeee');
    });
    // Function For Populate State  // This function we will call after select change country
    $scope.GetStates = function () {
        $scope.StateID = null; // Clear Selected State if any
        $scope.StateList = null; // Clear previously loaded state list
        $scope.StateTextToShow = "Please Wait..."; // this will show until load states from database

        //Load State 
        LocationService.GetStates($scope.ZoneID).then(function (d) {
            $scope.StatesList = d.data;
            $scope.StateTextToShow = "Select State";
        }, function (error) {
            alert('Error!');
        });

    }
    // Function for show result
    $scope.ShowResult = function () {
        $scope.Result = "Selected Zone ID : " + $scope.ZoneID + " State ID : " + $scope.StateID;
    }

})
app.factory('LocationService', function ($http) { // explained about factory in Part2
    var fac = {};
    fac.GetZones = function () {
        return $http.get('/STATEs/GetZones')
    }
    fac.GetStates = function (zoneID) {
        return $http.get('/STATEs/GetStates?ZoneID=' + zoneID)
    }
    return fac;
});