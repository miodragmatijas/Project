

var app = angular.module('vehicleModule', ['ngRoute']);

app.config(function ($routeProvider) {
    $routeProvider


        .when('/vehicleMake', {
            templateUrl: 'app/View/VehicleMake/index.html',
            controller: 'VehicleMakeController'
        })
        .when('/MakeDetails', {
            templateUrl: 'app/View/VehicleMake/details.html',
            controller: 'MakeDetails'
        });

});