var vehicleModule = angular.module('vehicleModule', ['ngRoute']);

vehicleModule.config(function ($routeProvider) {

    $routeProvider
        .when('/vehicleMake', {
            templateUrl: 'app/View/VehicleMake/index.html',
            controller: 'VehicleMakeController'
        })
        .when('/MakeDetails/:ID', {
            templateUrl: 'app/View/VehicleMake/details.html',
            controller: 'MakeDetailsController'
        })
        .when('/MakeAdd', {
            templateUrl: 'app/View/VehicleMake/add.html',
            controller: 'MakeAddController'
        })
        .when('/MakeEdit/:ID', {
            templateUrl: 'app/View/VehicleMake/edit.html'
            //controller: 'MakeDetailsController'
        });
});