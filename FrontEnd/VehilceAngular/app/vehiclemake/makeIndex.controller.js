angular
    .module('app')
    .controller('VehicleMakeController',VehicleMakeController);

function VehicleMakeController($scope,$http) {

    $http.get('http://localhost:64407/api/vehicle')
        .then(function (response) { $scope.vehicleMake = response.data; });

}